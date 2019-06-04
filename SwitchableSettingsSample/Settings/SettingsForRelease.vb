''' <summary>
''' リリース環境向けのアプリケーション設定です。コンフィグ ファイルの値を参照します。
''' </summary>
Friend Class SettingsForRelease
    Inherits SettingsBase

    ' [Memo] リリース環境向け
    ' 基本的にMySettingsの値を返すようにする。

    Public Overrides ReadOnly Property Name As String
        Get
            Return "リリース環境向け"
        End Get
    End Property

    Public Overrides ReadOnly Property ConnectionString As String
        Get
            Return My.Settings.ConnectionString
        End Get
    End Property

    Public Overrides ReadOnly Property CommandTimeoutSeconds As Integer
        Get
            Return My.Settings.CommandTimeoutSeconds
        End Get
    End Property

End Class
