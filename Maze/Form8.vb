Public Class Form8

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location()
        StartingPoint.Offset(257, 407)
        Cursor.Position = PointToScreen(StartingPoint)


    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter, Panel1.MouseEnter, MyBase.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label24.MouseEnter, Label2.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label10.MouseEnter
        MoveToStart()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) _
                                               Handles Panel1.MouseDown
        Panel1.Capture = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form9.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form7.Show()

    End Sub
End Class