Imports System.Text.RegularExpressions
Public Class Form1


    Public Property ResultText() As String
        Get
            Return String.Empty
        End Get
        Set(ByVal value As String)
            Me.txtResult.Text += value & System.Environment.NewLine
            Me.txtResult.SelectAll()
            Me.txtResult.ScrollToCaret()
        End Set
    End Property

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtOrigin.Text = "The brown fox jumps over the lazy dog"
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        If txtRegex.Text.Equals(String.Empty) Then
            ResultText = "regex empty"
            Return
        End If
        Try
            doSearch()
        Catch ex As Exception
            ResultText = ex.Message
            Return
        End Try

    End Sub

    Private Sub doSearch()
        '   Dim r As Regex
        Dim m As Match
        '   r = New Regex(_regexPattern)
        '   m = r.Match(_origineText)
        m = Regex.Match(txtOrigin.Text, txtRegex.Text, RegexOptions.Multiline)
        While m.Success
            ResultText = String.Format(My.Resources.matchResult, m.Groups(0), m.Index.ToString)
            m = m.NextMatch()
        End While


    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        My.Forms.Help.Show()
    End Sub

    Private Sub btnOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOutput.Click
        If txtFormat.Text.Equals(String.Empty) Then
            ResultText = "MyFormat is empty"
            Return
        End If
        Try
            doReFormat()
        Catch ex As Exception
            ResultText = ex.Message
            Return
        End Try
    End Sub
    Private Sub doReformat()
        Dim _from, _till As Integer
        Dim _out = String.Empty
        Dim _source = txtOrigin.Text.Trim
        Dim _regexPattern = txtRegex.Text

        If Integer.TryParse(txtOuput.Text.Trim, _from) AndAlso Integer.TryParse(txtOutPutTill.Text.Trim, _till) AndAlso _till > _from Then
            For _i As Integer = _from To _till
                If String.IsNullOrEmpty(txtFormat.Text) Then
                    _out += Regex.Replace(_source, _regexPattern, _i.ToString)
                    _out += Environment.NewLine
                Else
                    _out += Regex.Replace(_source, _regexPattern, String.Format("{0:" & txtFormat.Text.Trim & "}", _i))
                    _out += Environment.NewLine
                End If
            Next
        Else
            _out = Regex.Replace(_source, _regexPattern, txtOuput.Text)
        End If

        ResultText = _out

    End Sub


End Class
