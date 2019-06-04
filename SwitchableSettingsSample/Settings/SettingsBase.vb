''' <summary>
''' アプリケーション設定をサポートするための基本クラスです。
''' </summary>
Public MustInherit Class SettingsBase

#Region "MySettings 基本操作"

    ''' <summary>
    ''' 永続ストレージからのアプリケーション設定のプロパティ値を更新します。
    ''' </summary>
    Public Overridable Sub Reload()
        My.Settings.Reload()
    End Sub

    ''' <summary>
    ''' 対応する初期設定のプロパティを永続化されたアプリケーション設定の値を復元します。
    ''' </summary>
    Public Overridable Sub Reset()
        My.Settings.Reset()
    End Sub

    ''' <summary>
    ''' アプリケーション設定のプロパティの現在の値を格納します。
    ''' </summary>
    Public Overridable Sub Save()
        My.Settings.Save()
    End Sub

    ''' <summary>
    ''' アプリケーションの最新のインストールを反映するようにアプリケーションの設定を更新します。
    ''' </summary>
    Public Overridable Sub Upgrade()
        My.Settings.Upgrade()
    End Sub

#End Region

    ' [Memo] 設定項目の定義
    ' My Project の設定で定義している項目をそのままの構成でプロパティに落とし込む。
    ' ただし、Name プロパティは設定で使われていない項目で、この仕組み固有のもの。
    ' アプリケーション スコープの場合は ReadOnly / MustOverride 指定。(派生クラスで実際の値を指定させる)
    ' ユーザー スコープの場合は Overridable 指定。(値の読み書きの実装は面倒なのでここはMySettingsの仕組みを共用する。初期値を変更したい場合は派生先でオーバーライドさせる)

    ''' <summary>
    ''' このアプリケーション設定の名前を取得します。
    ''' </summary>
    Public MustOverride ReadOnly Property Name As String

    ''' <summary>
    ''' SQL Server データベースへの接続文字列を取得します。
    ''' </summary>
    Public MustOverride ReadOnly Property ConnectionString As String

    ''' <summary>
    ''' SQL Server に対してコマンドを実行してエラー終了するまでのタイムアウト時間を秒単位で取得します。
    ''' </summary>
    Public MustOverride ReadOnly Property CommandTimeoutSeconds As Integer

    ''' <summary>
    ''' 入力ファイルのパスを取得または設定します。
    ''' </summary>
    Public Overridable Property InputPath As String
        Get
            Return My.Settings.InputPath
        End Get
        Set(value As String)
            My.Settings.InputPath = value
        End Set
    End Property

    ''' <summary>
    ''' 出力ファイルのパスを取得または設定します。
    ''' </summary>
    Public Overridable Property OutputPath As String
        Get
            Return My.Settings.OutputPath
        End Get
        Set(value As String)
            My.Settings.OutputPath = value
        End Set
    End Property

    ''' <summary>
    ''' チェック ボックスの選択状態を取得または設定します。
    ''' </summary>
    Public Overridable Property CheckedValue As Boolean
        Get
            Return My.Settings.CheckedValue
        End Get
        Set(value As Boolean)
            My.Settings.CheckedValue = value
        End Set
    End Property

    ''' <summary>
    ''' リスト ボックスの選択インデックスを取得または設定します。
    ''' </summary>
    Public Overridable Property ListSelectedIndex As Integer
        Get
            Return My.Settings.ListSelectedIndex
        End Get
        Set(value As Integer)
            My.Settings.ListSelectedIndex = value
        End Set
    End Property

End Class
