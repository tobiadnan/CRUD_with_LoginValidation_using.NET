Imports System.Data
Imports System.Data.SqlClient

Public Class KaryawanForm
    Dim objCmd As New SqlCommand
    Dim objDataAdapter As New SqlDataAdapter
    Dim objDataSet As New DataSet
    Dim objDataTableForShow As New DataTable
    Dim objDataTable2 As New DataTable
    Dim objDataReader As SqlDataReader
    Dim myConnection As New Connection.VbConnection
    Dim strSQL, JenisK As String
    Private Sub KaryawanForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Call style()
        Call getData()
        Call clearData()
        Call nik()
    End Sub

    Sub style()
        With DataGridView1
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.Font = New Font("Franklin Gothic Book, ", 9)
            .DefaultCellStyle.ForeColor = Color.Black
            .ColumnHeadersDefaultCellStyle.Font = New Font("Franklin Gothic Book, ", 10, FontStyle.Bold)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        End With

    End Sub

    Private Sub getData()
        On Error Resume Next
        objDataTableForShow.Clear()
        strSQL = "SELECT * FROM tblKaryawan"

        objCmd.Connection = myConnection.Open
        objCmd.CommandType = CommandType.Text
        objCmd.CommandText = strSQL
        objDataAdapter = New SqlDataAdapter(objCmd)
        objDataAdapter.Fill(objDataSet, "dataKaryawan")
        myConnection.Close()
        objDataTableForShow = objDataSet.Tables("dataKaryawan")
        DataGridView1.DataSource = objDataTableForShow

        strSQL = ""

    End Sub

    Private Sub nik()
        Call getAuto()
        If objDataTable2.Rows.Count = 0 Then
            tbNik.Text = "KAR-00002021"
        Else
            With objDataTable2.Rows(0)
                tbNik.Text = .Item("nik")
            End With
            tbNik.Text = Val(Microsoft.VisualBasic.Mid(tbNik.Text, 5, 8)) + 1
            If Len(tbNik.Text) = 1 Then
                tbNik.Text = "KAR-0000202" & tbNik.Text & ""
            ElseIf Len(tbNik.Text) = 2 Then
                tbNik.Text = "KAR-000020" & tbNik.Text & ""
            ElseIf Len(tbNik.Text) = 3 Then
                tbNik.Text = "KAR-00002" & tbNik.Text & ""
            ElseIf Len(tbNik.Text) = 4 Then
                tbNik.Text = "KAR-0000" & tbNik.Text & ""
            ElseIf Len(tbNik.Text) = 5 Then
                tbNik.Text = "KAR-000" & tbNik.Text & ""
            ElseIf Len(tbNik.Text) = 6 Then
                tbNik.Text = "KAR-00" & tbNik.Text & ""
            ElseIf Len(tbNik.Text) = 7 Then
                tbNik.Text = "KAR-0" & tbNik.Text & ""
            ElseIf Len(tbNik.Text) = 8 Then
                tbNik.Text = "KAR-" & tbNik.Text & ""
            End If
        End If
    End Sub
    Private Sub getAuto()

        objDataTable2.Clear()
        strSQL = "SELECT * FROM tblKaryawan ORDER BY nik DESC"
        objCmd.Connection = myConnection.Open
        objCmd.CommandType = CommandType.Text
        objCmd.CommandText = strSQL
        objDataAdapter = New SqlDataAdapter(objCmd)
        objDataAdapter.Fill(objDataSet, "getAuto")
        myConnection.Close()
        objDataTable2 = objDataSet.Tables("getAuto")
        'dgPasien.DataSource = objDataTable2

    End Sub

    Private Sub clearData()
        tbNik.Focus()
        tbNama.Text = ""
        tbKtp.Text = ""
        tbAlamat.Text = ""
        comboGolDar.Text = "O"
        tbTlp.Text = ""
        comboAgama.Text = "ISLAM"
        tbUmur.Text = ""
        tbJmlAnak.Text = ""
        comboStatus.Text = "SINGLE"
        JenisK = ""

        btnSimpan.Enabled = False
        btnHapus.Enabled = False
        btnCancel.Enabled = True

        btnSimpan.Text = "Simpan"
        btnCancel.Text = "Close"

    End Sub

    Private Sub checkData()
        Try
            objDataTable2.Clear()
            strSQL = "SELECT * FROM tblKaryawan WHERE nik = '" & tbNik.Text & "'"
            objCmd.Connection = myConnection.Open
            objCmd.CommandType = CommandType.Text
            objCmd.CommandText = strSQL
            objDataAdapter = New SqlDataAdapter(objCmd)
            objDataAdapter.Fill(objDataSet, "checkData")
            myConnection.Close()
            objDataTable2 = objDataSet.Tables("checkData")
            'dgPasien.DataSource = objDataTableForShow
        Catch ex As Exception

        End Try
    End Sub


    Private Sub tbNik_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbNik.KeyUp
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            Call checkData()
            If objDataTable2.Rows.Count = 0 Then
                btnHapus.Enabled = False
            Else
                objCmd = myConnection.Open.CreateCommand
                objCmd.CommandText = "SELECT * FROM tblKaryawan WHERE nik = '" & tbNik.Text & "'"
                objDataReader = objCmd.ExecuteReader
                objDataReader.Read()
                tbNama.Text = objDataReader.Item("nama")
                tbKtp.Text = objDataReader.Item("noKtp")
                If objDataReader.Item("jenisK") = "L" Then
                    radioMale.Checked = True
                ElseIf objDataReader.Item("jenisK") = "P" Then
                    radioFemale.Checked = True
                End If
                tbAlamat.Text = objDataReader.Item("alamat")
                comboGolDar.Text = objDataReader.Item("golDar")
                tbTlp.Text = objDataReader.Item("noTlp")
                comboAgama.Text = objDataReader.Item("agama")
                tbUmur.Text = objDataReader.Item("umur")
                tbJmlAnak.Text = objDataReader.Item("jumlahAnak")
                comboPendidikan.Text = objDataReader.Item("pendidikanTerakhir")
                comboStatus.Text = objDataReader.Item("statusPerkawinan")
                myConnection.Close()
                btnHapus.Enabled = True
                btnSimpan.Text = "Update"
            End If

            If JenisK = "L" Then
                radioMale.Checked = True
            ElseIf JenisK = "P" Then
                radioFemale.Checked = True
            End If
            btnCancel.Text = "Cancel"
            btnSimpan.Enabled = True
            tbNama.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            tbNama.Focus()
        End If
    End Sub

    Private Sub tbNama_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbNama.KeyUp
        If e.KeyCode = Keys.Enter Then
            tbKtp.Focus()
        End If
    End Sub

    Private Sub tbKtp_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbKtp.KeyUp
        If e.KeyCode = Keys.Enter Then
            tbAlamat.Focus()
        End If
    End Sub

    Private Sub tbAlamat_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbAlamat.KeyUp
        If e.KeyCode = Keys.Enter Then
            tbTlp.Focus()
        End If
    End Sub

    Private Sub tbTlp_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbTlp.KeyUp
        If e.KeyCode = Keys.Enter Then
            radioMale.Checked = True
        End If
    End Sub

    Private Sub tbUmur_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbUmur.KeyUp
        If e.KeyCode = Keys.Enter Then
            tbJmlAnak.Focus()
        End If
    End Sub

    Private Sub tbJmlAnak_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbJmlAnak.KeyUp
        If e.KeyCode = Keys.Enter Then
            comboPendidikan.Focus()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        On Error Resume Next

        Call validationSave()

        radioFemale.Checked = False
        radioMale.Checked = False

    End Sub
    Private Sub executeCRUD()
        myConnection.Close()
        objCmd.CommandText = strSQL
        objCmd.Connection = myConnection.Open
        objCmd.ExecuteNonQuery()
        myConnection.Close()
        strSQL = ""

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If btnCancel.Text = "Close" Then
            LoginForm.Close()
        Else
            Call clearData()
            Call nik()

        End If
    End Sub

    Private Sub btnHapus_Click(sender As System.Object, e As System.EventArgs) Handles btnHapus.Click
        If Len(Trim(tbNik.Text)) = 0 Then
            Exit Sub
        End If
        Dim mYes_No As String = MsgBox("Delete " & tbNama.Text & " Are you sure ?", vbYesNo)
        If mYes_No = vbYes Then
            strSQL = "DELETE FROM tblKaryawan WHERE nik = '" & tbNik.Text & "'"

            Call executeCRUD()
            MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information)
            Call getData()
            Call clearData()

        End If
    End Sub

    Private Sub validationSave()
        Call ifRadioChecked()
        If tbNama.Text = "" Then
            MsgBox("Nama harus diisi", MsgBoxStyle.Exclamation, "")
            tbNama.Focus()
        ElseIf tbNik.Text = "" Then
            MsgBox("Nomor Induk Karyawan harus diisi", MsgBoxStyle.Exclamation, "")
            tbNik.Focus()
        ElseIf tbKtp.Text = "" Then
            MsgBox("No. KTP harus diisi", MsgBoxStyle.Exclamation, "")
            tbKtp.Focus()
        ElseIf tbAlamat.Text = "" Then
            MsgBox("Alamat harus diisi", MsgBoxStyle.Exclamation, "")
            tbAlamat.Focus()
        ElseIf tbTlp.Text = "" Then
            MsgBox("No. Telpon harus diisi", MsgBoxStyle.Exclamation, "")
            tbTlp.Focus()
        ElseIf comboAgama.Text = "" Then
            MsgBox("Agama tidak boleh kosong", MsgBoxStyle.Exclamation, "")
            comboAgama.Focus()
        ElseIf comboGolDar.Text = "" Then
            MsgBox("Golongan Darah tidak boleh kosong", MsgBoxStyle.Exclamation, "")
            comboGolDar.Focus()
        ElseIf tbUmur.Text = "" Then
            MsgBox("Umur harus diisi", MsgBoxStyle.Exclamation, "")
            tbUmur.Focus()
        ElseIf tbJmlAnak.Text = "" Then
            MsgBox("Jumlah Anak harus diisi", MsgBoxStyle.Exclamation, "")
            tbJmlAnak.Focus()
        ElseIf comboPendidikan.Text = "" Then
            MsgBox("Pendidikan Terakhir tidak boleh kosong", MsgBoxStyle.Exclamation, "")
            comboPendidikan.Focus()
        ElseIf comboStatus.Text = "" Then
            MsgBox("Status Perkawinan tidak boleh kosong", MsgBoxStyle.Exclamation, "")
            comboStatus.Focus()
        Else
            If btnSimpan.Text = "Simpan" Then

                strSQL = "INSERT INTO tblKaryawan VALUES ('" & tbNik.Text & "', '" & tbNama.Text & "','" & tbKtp.Text & "', '" & JenisK & "','" & tbAlamat.Text & "', '" & comboGolDar.Text & "','" & tbTlp.Text & "', '" & comboAgama.Text & "','" & tbUmur.Text & "', '" & tbJmlAnak.Text & "','" & comboPendidikan.Text & "', '" & comboStatus.Text & "')"
                MsgBox("Data Telah Tersimpan", vbInformation, "Informasi")
            Else
                Call ifRadioChecked()
                strSQL = "UPDATE tblKaryawan SET nama = '" & tbNama.Text & "', noKtp = '" & tbKtp.Text & "', jenisK = '" & JenisK & "', alamat = '" & tbAlamat.Text & "', golDar = '" & comboGolDar.Text & "', noTlp = '" & tbTlp.Text & "', agama = '" & comboAgama.Text & "', umur = '" & tbUmur.Text & "', jumlahAnak = '" & tbJmlAnak.Text & "', pendidikanTerakhir = '" & comboPendidikan.Text & "', statusPerkawinan = '" & comboStatus.Text & "' WHERE nik = '" & tbNik.Text & "'"
                MsgBox("Data " & tbNama.Text & " Berhasil Di Update", vbInformation, "Informasi")
            End If
            Call executeCRUD()
            Call getData()
            Call clearData()
            Call nik()
        End If
    End Sub

    Private Sub ifRadioChecked()
        If radioMale.Checked Then
            JenisK = "L"
        ElseIf radioFemale.Checked Then
            JenisK = "P"
        End If
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        With DataGridView1
            On Error Resume Next
            Dim sRow As Integer = .CurrentRow.Index
            tbNik.Text = .Item(0, sRow).Value
            tbNama.Text = .Item(1, sRow).Value
            tbKtp.Text = .Item(2, sRow).Value
            If radioFemale.Checked = True Then
                JenisK = "Perempuan"
            ElseIf radioMale.Checked = True Then
                JenisK = "Laki-laki"
            End If
            JenisK = .Item(3, sRow).Value
            tbAlamat.Text = .Item(4, sRow).Value
            comboGolDar.Text = .Item(5, sRow).Value
            tbTlp.Text = .Item(6, sRow).Value
            comboAgama.Text = .Item(7, sRow).Value
            tbUmur.Text = .Item(8, sRow).Value
            tbJmlAnak.Text = .Item(9, sRow).Value
            comboPendidikan.Text = .Item(10, sRow).Value
            comboStatus.Text = .Item(11, sRow).Value

            btnSimpan.Text = "Update"
            btnSimpan.Enabled = True
            btnHapus.Enabled = True
            btnCancel.Text = "Cancel"
            btnCancel.Enabled = True

        End With
    End Sub
End Class