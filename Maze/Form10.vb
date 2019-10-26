Public Class Form10
    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label63.MouseEnter, Label85.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label59.MouseEnter, Label57.MouseEnter, Label55.MouseEnter, Panel2.MouseEnter, Label62.MouseEnter, Label108.MouseEnter, Label120.MouseEnter, Label119.MouseEnter, Label107.MouseEnter, Label113.MouseEnter, Label117.MouseEnter, Label125.MouseEnter, Label126.MouseEnter, Label127.MouseEnter, Label130.MouseEnter, Label133.MouseEnter, Label92.MouseEnter, Label141.MouseEnter, Label134.MouseEnter, Label138.MouseEnter, Label129.MouseEnter, Label140.MouseEnter, Label139.MouseEnter
        MoveToStart()

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location()
        StartingPoint.Offset(44, 350)
        Cursor.Position = PointToScreen(StartingPoint)


    End Sub
    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label43_Click(sender As Object, e As EventArgs) Handles Label43.Click, Label62.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint, Panel2.Paint

    End Sub

    Private Sub Label64_Click(sender As Object, e As EventArgs) Handles Label106.Click, Label119.Click

    End Sub

    Private Sub Label69_Click(sender As Object, e As EventArgs) Handles Label105.Click

    End Sub

    Private Sub Label71_Click(sender As Object, e As EventArgs) Handles Label103.Click

    End Sub

    Private Sub Label70_Click(sender As Object, e As EventArgs) Handles Label104.Click, Label118.Click, Label115.Click, Label108.Click

    End Sub

    Private Sub Label73_Click(sender As Object, e As EventArgs) Handles Label101.Click, Label121.Click, Label114.Click, Label107.Click

    End Sub

    Private Sub Label72_Click(sender As Object, e As EventArgs) Handles Label102.Click

    End Sub

    Private Sub Label77_Click(sender As Object, e As EventArgs) Handles Label98.Click

    End Sub

    Private Sub Label76_Click(sender As Object, e As EventArgs) Handles Label99.Click, Label93.Click

    End Sub

    Private Sub Label74_Click(sender As Object, e As EventArgs) Handles Label100.Click, Label94.Click, Label113.Click

    End Sub

    Private Sub Label79_Click(sender As Object, e As EventArgs) Handles Label96.Click

    End Sub

    Private Sub Label80_Click(sender As Object, e As EventArgs) Handles Label80.Click, Label95.Click, Label90.Click, Label83.Click

    End Sub

    Private Sub Label78_Click(sender As Object, e As EventArgs) Handles Label92.Click, Label86.Click, Label85.Click, Label84.Click

    End Sub

    Private Sub Label124_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label125_Click(sender As Object, e As EventArgs) Handles Label125.Click

    End Sub

    Private Sub Label130_Click(sender As Object, e As EventArgs) Handles Label130.Click

    End Sub

    Private Sub Label50_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Label81_Click(sender As Object, e As EventArgs) Handles Label81.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class