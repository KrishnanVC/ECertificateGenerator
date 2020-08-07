Imports MaterialSkin
Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop.Excel
Imports iTextSharp.text.pdf
Imports System.Threading

Public Class Form1
    Dim trd As Thread
    Dim trd2 As Thread

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue700, Primary.Blue700, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub impexcel_Click(sender As Object, e As EventArgs) Handles impexcel1.Click
        Try
            Dim dialog As New OpenFileDialog()
            Dim pathe As String = ""
            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim dataSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            dialog.Filter = "Excel Files |*.xls;*.xlsx"
            If dialog.ShowDialog() = DialogResult.OK Then
                pathe = dialog.FileName
            End If
            excpath.Text = pathe
            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathe + ";Extended Properties=Excel 12.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection)
            dataSet = New System.Data.DataSet
            MyCommand.Fill(dataSet)
            DataGridView1.DataSource = dataSet.Tables(0)
            MyConnection.Close()
            previewlable.Visible = False
        Catch ex As Exception
            MessageBox.MaterialLabel1.Text = ex.Message.ToString
            MessageBox.Show()
        End Try
    End Sub

    Private Sub imptemp_Click(sender As Object, e As EventArgs) Handles imptemp.Click
        Try
            Dim dialog As New OpenFileDialog()
            Dim patht As String = ""
            dialog.Filter = "Word Files |*.doc;*.docx"
            If dialog.ShowDialog() = DialogResult.OK Then
                patht = dialog.FileName
            End If
            temppath.Text = patht
        Catch ex As Exception
            MessageBox.MaterialLabel1.Text = ex.Message.ToString
            MessageBox.Show()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pathex As String = ""
        Try
            If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
                pathex = FolderBrowserDialog1.SelectedPath & "\"
            End If
            expath.Text = pathex
        Catch ex As Exception
            MessageBox.MaterialLabel1.Text = ex.Message.ToString
            MessageBox.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If excpath.Text = "" Then
                MessageBox.MaterialLabel1.Text = "Enter a path for Excel"
                MessageBox.ShowDialog(Me)
                Exit Sub
            End If
            If temppath.Text = "" Then
                MessageBox.MaterialLabel1.Text = "Enter a path for Template"
                MessageBox.ShowDialog(Me)
                Exit Sub
            End If
            If Not System.IO.File.Exists(excpath.Text()) Then
                MessageBox.MaterialLabel1.Text = "Enter a valid path for Excel"
                MessageBox.ShowDialog(Me)
                Exit Sub
            End If
            If Not System.IO.File.Exists(temppath.Text()) Then
                MessageBox.MaterialLabel1.Text = "Enter a valid path for Template"
                MessageBox.ShowDialog(Me)
                Exit Sub
            End If
            Progress1.Visible = True
            Progress1.Value = 0
            trd = New Thread(AddressOf Process)
            trd.SetApartmentState(ApartmentState.STA)
            trd.Start()
            trd2 = New Thread(AddressOf Progress_fore)
            trd2.SetApartmentState(ApartmentState.STA)
            trd2.Start()
            Button1.Enabled = False
            MaterialRaisedButton1.Enabled = False
        Catch ex As Exception
            MessageBox.MaterialLabel1.Text = "Error: " & ex.ToString
            MessageBox.Show()
        End Try
    End Sub

    Public Shared Function MergePdfFiles(ByVal pdfFiles() As String, ByVal allinonepdf As String) As Boolean
        Dim result As Boolean = False
        Dim pdfCount As Integer = 0     'total input pdf file count
        Dim f As Integer = 0    'pointer to current input pdf file
        Dim fileName As String
        Dim reader As iTextSharp.text.pdf.PdfReader = Nothing
        Dim pageCount As Integer = 0
        Dim pdfDoc As iTextSharp.text.Document = Nothing    'the output pdf document
        Dim writer As PdfWriter = Nothing
        Dim cb As PdfContentByte = Nothing
        Dim page As PdfImportedPage = Nothing
        Dim rotation As Integer = 0

        Try
            pdfCount = pdfFiles.Length
            If pdfCount > 1 Then
                'Open the 1st item in the array PDFFiles
                fileName = pdfFiles(f)
                reader = New iTextSharp.text.pdf.PdfReader(fileName)
                'Get page count
                pageCount = reader.NumberOfPages

                pdfDoc = New iTextSharp.text.Document(reader.GetPageSizeWithRotation(1), 18, 18, 18, 18)

                writer = PdfWriter.GetInstance(pdfDoc, New FileStream(allinonepdf, FileMode.OpenOrCreate))

                With pdfDoc
                    .Open()
                End With
                'Instantiate a PdfContentByte object
                cb = writer.DirectContent
                'Now loop thru the input pdfs
                While f < pdfCount
                    'Declare a page counter variable
                    Dim i As Integer = 0
                    'Loop thru the current input pdf's pages starting at page 1
                    While i < pageCount
                        i += 1
                        'Get the input page size
                        pdfDoc.SetPageSize(reader.GetPageSizeWithRotation(i))
                        'Create a new page on the output document
                        pdfDoc.NewPage()
                        'If it is the 1st page, we add bookmarks to the page
                        'Now we get the imported page
                        page = writer.GetImportedPage(reader, i)
                        'Read the imported page's rotation
                        rotation = reader.GetPageRotation(i)
                        'Then add the imported page to the PdfContentByte object as a template based on the page's rotation
                        If rotation = 90 Then
                            cb.AddTemplate(page, 0, -1.0F, 1.0F, 0, 0, reader.GetPageSizeWithRotation(i).Height)
                        ElseIf rotation = 270 Then
                            cb.AddTemplate(page, 0, 1.0F, -1.0F, 0, reader.GetPageSizeWithRotation(i).Width + 60, -30)
                        Else
                            cb.AddTemplate(page, 1.0F, 0, 0, 1.0F, 0, 0)
                        End If
                    End While
                    'Increment f and read the next input pdf file
                    f += 1
                    If f < pdfCount Then
                        fileName = pdfFiles(f)
                        reader = New iTextSharp.text.pdf.PdfReader(fileName)
                        pageCount = reader.NumberOfPages
                    End If
                End While
                'When all done, we close the document so that the pdfwriter object can write it to the output file
                pdfDoc.Close()
                result = True
            End If
        Catch ex As Exception
            Return False
        End Try
        Return result
    End Function

    Public Shared Function qrcode(ByVal qrtext As String) As Image
        Dim qrGenerator As QRCoder.QRCodeGenerator = New QRCoder.QRCodeGenerator()
        Dim qrCodeData As QRCoder.QRCodeData = qrGenerator.CreateQrCode(qrtext, QRCoder.QRCodeGenerator.ECCLevel.Q)
        Dim qCode As QRCoder.QRCode = New QRCoder.QRCode(qrCodeData)
        Dim qrCodeImage As Bitmap = qCode.GetGraphic(3)
        Return qrCodeImage
    End Function

    Private Sub Process()
        System.Windows.Forms.Application.DoEvents()
        Dim docWD As Document
        Dim appWD As Word.Application
        Dim MyRow As Integer
        Dim MyCol As Integer
        Dim wRng
        Dim PDFPath As String
        Dim strSearch As String
        Dim strReplace As String
        Dim pathpdf As String
        Dim pathall As String
        Dim pathword As String
        Dim Letter_Path As String
        Dim appXl As Object
        Dim excelPath As String = excpath.Text().ToString
        Dim wordPath As String = temppath.Text().ToString
        Dim xlWorkBook As Object
        Dim xlWorkSheet As Object
        Dim TotalCount As Integer
        Dim rowcount As Integer
        Dim progresscount As Integer
        Dim count As Integer
        appXl = New Excel.Application
        xlWorkBook = appXl.Workbooks.Open(excelPath, , ReadOnly:=False)
        xlWorkSheet = xlWorkBook.Worksheets("Sheet1")
        Letter_Path = expath.Text().ToString
        appXl.Application.ScreenUpdating = False
        appXl.Application.DisplayAlerts = False
        xlWorkBook.ActiveSheet.Range("A1:A1000").Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternNone
        appWD = New Word.Application
        With xlWorkSheet
            rowcount = .Cells(.Rows.Count, "B").End(Microsoft.Office.Interop.Excel.XlDirection.xlUp).row - 1
            count = Math.Floor(100 / rowcount)
            progresscount = count
            count = 0
            For MyRow = 2 To .Cells(.Rows.Count, "B").End(Microsoft.Office.Interop.Excel.XlDirection.xlUp).row
                docWD = appWD.Documents.Open(temppath.Text().ToString, , ReadOnly:=False)
                appWD.Visible = False
                TotalCount = docWD.Characters.Count
                wRng = docWD.Range(Start:=0, End:=TotalCount)
                docWD.Activate()
                For MyCol = 2 To .Cells(MyRow, .Columns.Count).End(Microsoft.Office.Interop.Excel.XlDirection.xlToLeft).Column + 1
                    With wRng.find
                        strSearch = xlWorkBook.ActiveSheet.Cells(1, MyCol).Value
                        strReplace = xlWorkBook.ActiveSheet.Cells(MyRow, MyCol).Value
                        .Forward = True
                        .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindStop
                        .MatchWildcards = True
                        .Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)
                        If (Not strSearch = "#QRCode#") Then
                            .Execute(FindText:=strSearch, ReplaceWith:=strReplace, Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)
                        ElseIf strSearch = "#QRCode#" AndAlso (CheckBox1.Checked = True) AndAlso (Not qrurl.Text = "") Then
                            Dim QR As Image = qrcode(qrurl.Text)
                            Dim rng As Word.Range
                            rng = docWD.Content
                            rng.Find.Execute("#QRCode#")
                            Clipboard.SetImage(QR)
                            rng.Paste()
                        End If
                    End With
                    MyCol = MyCol
                Next MyCol
                pathpdf = Letter_Path & "/PDF"
                pathword = Letter_Path & "/Word"
                If (Not System.IO.Directory.Exists(pathpdf)) Then
                    System.IO.Directory.CreateDirectory(pathpdf)
                End If
                If (Not System.IO.Directory.Exists(pathword)) Then
                    System.IO.Directory.CreateDirectory(pathword)
                End If
                PDFPath = pathpdf & "\" & .Cells(MyRow, "b").Value & ".pdf"
                Do Until (System.IO.File.Exists(PDFPath))
                    docWD.ExportAsFixedFormat(PDFPath, Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF, False)
                    Threading.Thread.Sleep(1)
                Loop
                Do Until (System.IO.File.Exists(pathword & "\" & .Cells(MyRow, "b").Value & ".docx"))
                    appWD.ActiveDocument.SaveAs(FileName:=pathword & "\" & .Cells(MyRow, "b").Value & ".docx")
                    Threading.Thread.Sleep(1)
                Loop
                Progress1.Invoke(
                    Sub()
                        Dim var As Integer

                        For var = 0 To progresscount Step 1
                            Progress1.Value = count + var
                            Progress1.Text = count + var
                            Threading.Thread.Sleep(200)
                        Next var
                    End Sub
                    )
                count += progresscount
                docWD.Close()
                docWD = Nothing
                .Cells(MyRow, "A").Interior.Color = RGB(148, 208, 80)
            Next MyRow
        End With
        appWD.Quit()
        'appWD.ShowMe
        appXl.Application.ScreenUpdating = True
        appXl.Application.DisplayAlerts = True
        pathall = Letter_Path & "\All in One"
        If (Not System.IO.Directory.Exists(pathall)) Then
            System.IO.Directory.CreateDirectory(pathall)
        End If
        Dim allinonepdf As String = pathall & "\Allinonepdf.pdf"
        Dim pdfFiles() As String = Directory.GetFiles(pathpdf)

        Do Until (System.IO.File.Exists(allinonepdf))
            MergePdfFiles(pdfFiles, allinonepdf)
            Threading.Thread.Sleep(1)
        Loop
        Dim allinoneword As String = pathall & "\Allinoneword.docx"
        Dim wordfiles() As String = Directory.GetFiles(pathword)
        Do Until (System.IO.File.Exists(allinoneword))
            MergeWordFiles(wordfiles, allinoneword)
            Threading.Thread.Sleep(1)
        Loop
        Progress1.Value = 100
        Progress1.Text = 100
        xlWorkBook.Save
        xlWorkBook.Close()
        appXl.Quit()
        Marshal.ReleaseComObject(xlWorkBook)
        Marshal.ReleaseComObject(appXl)
        appXl = Nothing
        Marshal.ReleaseComObject(appWD)
        appWD = Nothing
        MessageBox.MaterialLabel1.Text = "Certificates Generated Successfully!"
        MessageBox.ShowDialog(Me)
        Button1.Enabled = True
        MaterialRaisedButton1.Enabled = True
        Call Shell("explorer.exe " & Letter_Path, vbNormalFocus)
        Progress1.Invoke(
            Sub()
                Progress1.Visible = False
            End Sub
            )
    End Sub

    Sub Progress_fore()
        Dim var As Long = 64
        While trd.IsAlive
            For var = 55 To 255
                Progress1.Invoke(
                    Sub()
                        Progress1.OuterColor = Color.FromArgb(var, var, var)
                    End Sub
                     )
                Threading.Thread.Sleep(10)
            Next var
            For var = 255 To 55 Step -1
                Progress1.Invoke(
                    Sub()
                        Progress1.OuterColor = Color.FromArgb(var, var, var)
                    End Sub
                     )
                Threading.Thread.Sleep(10)
            Next var
        End While
    End Sub

    Public Shared Function MergeWordFiles(ByVal wordfiles() As String, ByVal allinoneword As String) As Boolean
        Dim result As Boolean = False
        Try
            Dim objWord As Object
            Dim intCount As Integer = 0
            objWord = CreateObject("Word.Application")
            Dim file As String
            For Each file In wordfiles
                If intCount = 0 Then
                    objWord.Documents.Add(file)
                Else
                    objWord.Selection.InsertFile(filename:=file, Range:="", ConfirmConversions:=False, Link:=False, Attachment:=False)
                End If
                objWord.Selection.EndKey(Microsoft.Office.Interop.Word.WdUnits.wdStory)
                intCount += 1
                If Not intCount = wordfiles.Length Then
                    objWord.Selection.InsertNewPage()
                End If
            Next
            objWord.ActiveDocument.SaveAs(FileName:=allinoneword)
            objWord.Quit()
            result = True
        Catch ex As Exception
            result = False
        End Try
        Return False
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            While Panel1.Height > 2
                Panel1.Size = New Size(Panel1.Width, Panel1.Height - 2)
            End While
            While Me.Height > 528
                Me.Size = New Size(Me.Width, Me.Height - 2)
            End While
            Panel1.Visible = False
            qrurl.Text() = ""
        Else
            While Panel1.Height < 100
                Panel1.Size = New Size(Panel1.Width, Panel1.Height + 3)
            End While
            While Me.Height < 604
                Me.Size = New Size(Me.Width, Me.Height + 3)
            End While
            Panel1.Visible = True
        End If
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        excpath.Text = Nothing
        temppath.Text = Nothing
        qrurl.Text = Nothing
        CheckBox1.Checked = False
        expath.Text = Nothing
        DataGridView1.DataSource.Clear()
        DataGridView1.Columns.Clear()
        previewlable.Visible = True
    End Sub
End Class