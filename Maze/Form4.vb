Public Class Form4

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label6.MouseEnter, Panel1.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label137.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label1.MouseEnter
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
        StartingPoint.Offset(30, 415)
        Cursor.Position = PointToScreen(StartingPoint)


    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form6.Show()

    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) _
                                               Handles Panel1.MouseDown
        Panel1.Capture = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class