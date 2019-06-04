''' <summary>
''' アプリケーション設定を管理するユーティリティ クラスです。
''' </summary>
Public NotInheritable Class App

    ''' <summary>
    ''' アプリケーション設定を取得します。
    ''' </summary>
    Public Shared ReadOnly Property Settings As SettingsBase = New SettingsForRelease()
    ' [Memo] 設定の切り替え方
    ' ↑のプロパティに代入しているクラスを変更する。それだけ。

#Region "インスタンス生成の禁止"
    Private Sub New()
    End Sub
#End Region

End Class
