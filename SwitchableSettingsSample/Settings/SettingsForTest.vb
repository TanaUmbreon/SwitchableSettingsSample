''' <summary>
''' テスト環境向けのアプリケーション設定です。コンフィグ ファイルの値を参照します。
''' </summary>
Friend Class SettingsForTest
    Inherits SettingsBase

    ' [Memo] テスト環境向け
    ' 必要に応じて任意の固定値を返す。
    ' ユーザー スコープの設定項目は必要に応じてオーバーライドする。しない場合は MySettings で定義された値を使用する。
    ' 設定構成がさらに必要な場合は、クラス名を変えて同様の構成で作成する。

    Public Overrides ReadOnly Property Name As String
        Get
            Return "テスト環境向け"
        End Get
    End Property

    Public Overrides ReadOnly Property ConnectionString As String
        Get
            Return "Data Source=TESTSVR;Initial Catalog=Umbreon;User ID=sa;Password=password;Connection Timeout=3;"
        End Get
    End Property

    Public Overrides ReadOnly Property CommandTimeoutSeconds As Integer
        Get
            Return 5
        End Get
    End Property

    Public Overrides Property InputPath As String
        Get
            Return ".\Input.txt"
        End Get
        Set(value As String)
            ' テスト環境の値で保存させない
            'MyBase.InputPath = value
        End Set
    End Property

    Public Overrides Property OutputPath As String
        Get
            Return ".\Output.txt"
        End Get
        Set(value As String)
            ' テスト環境の値で保存させない
            'MyBase.OutputPath = value
        End Set
    End Property

End Class
