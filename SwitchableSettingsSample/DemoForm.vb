Public Class DemoForm

    Private Sub DemoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' リリース環境以外の設定にしている場合はタイトルバーにそうであることを表示させる
        ' (いわゆるミズゴロウもというっかり設定戻し忘れミス対策)
        If Not TypeOf App.Settings Is SettingsForRelease Then
            Text &= $" - {App.Settings.Name}"
        End If

        ' アプリケーション設定の取得
        connectionStringTextBox.Text = App.Settings.ConnectionString
        commandTimeoutSecondsTextBox.Text = App.Settings.CommandTimeoutSeconds.ToString()
        inputPathTextBox.Text = App.Settings.InputPath
        outputPathTextBox.Text = App.Settings.OutputPath
        checkedValueCheckBox.Checked = App.Settings.CheckedValue
        Dim index As Integer = App.Settings.ListSelectedIndex
        If (index >= 0) AndAlso (index < listSelectedIndexComboBox.Items.Count) Then
            listSelectedIndexComboBox.SelectedIndex = index
        End If
    End Sub

    Private Sub DemoForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ' アプリケーション設定の保存
        App.Settings.InputPath = inputPathTextBox.Text
        App.Settings.OutputPath = outputPathTextBox.Text
        App.Settings.CheckedValue = checkedValueCheckBox.Checked
        App.Settings.ListSelectedIndex = listSelectedIndexComboBox.SelectedIndex
        App.Settings.Save()
    End Sub

End Class
