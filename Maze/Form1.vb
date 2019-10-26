Public Class Form1

    Private Sub Label182_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Label182_MouseEnter(sender As Object, e As EventArgs)
        'Show a congratulator messagebox, then clsoe the form.
        MessageBox.Show("Well, somehow, in someway, you completed this. I'm not sure if you are just a cheater or one lucky son of a bitch but congrats noob")
        Close()
    End Sub
    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location()
        StartingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(StartingPoint)


    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label173.MouseEnter, Panel3.MouseEnter, Panel2.MouseEnter, Panel1.MouseEnter, Label99.MouseEnter, Label98.MouseEnter, Label97.MouseEnter, Label96.MouseEnter, Label95.MouseEnter, Label94.MouseEnter, Label93.MouseEnter, Label92.MouseEnter, Label91.MouseEnter, Label90.MouseEnter, Label9.MouseEnter, Label89.MouseEnter, Label88.MouseEnter, Label87.MouseEnter, Label86.MouseEnter, Label85.MouseEnter, Label84.MouseEnter, Label83.MouseEnter, Label82.MouseEnter, Label81.MouseEnter, Label80.MouseEnter, Label8.MouseEnter, Label79.MouseEnter, Label78.MouseEnter, Label77.MouseEnter, Label76.MouseEnter, Label75.MouseEnter, Label74.MouseEnter, Label73.MouseEnter, Label72.MouseEnter, Label71.MouseEnter, Label70.MouseEnter, Label7.MouseEnter, Label69.MouseEnter, Label68.MouseEnter, Label67.MouseEnter, Label66.MouseEnter, Label65.MouseEnter, Label64.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label6.MouseEnter, Label59.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label5.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label181.MouseEnter, Label180.MouseEnter, Label18.MouseEnter, Label179.MouseEnter, Label178.MouseEnter, Label177.MouseEnter, Label176.MouseEnter, Label175.MouseEnter, Label174.MouseEnter, Label172.MouseEnter, Label171.MouseEnter, Label170.MouseEnter, Label17.MouseEnter, Label169.MouseEnter, Label168.MouseEnter, Label167.MouseEnter, Label166.MouseEnter, Label165.MouseEnter, Label164.MouseEnter, Label163.MouseEnter, Label162.MouseEnter, Label161.MouseEnter, Label160.MouseEnter, Label16.MouseEnter, Label159.MouseEnter, Label158.MouseEnter, Label157.MouseEnter, Label156.MouseEnter, Label155.MouseEnter, Label154.MouseEnter, Label153.MouseEnter, Label152.MouseEnter, Label151.MouseEnter, Label150.MouseEnter, Label15.MouseEnter, Label149.MouseEnter, Label148.MouseEnter, Label147.MouseEnter, Label146.MouseEnter, Label145.MouseEnter, Label144.MouseEnter, Label143.MouseEnter, Label142.MouseEnter, Label141.MouseEnter, Label140.MouseEnter, Label14.MouseEnter, Label139.MouseEnter, Label138.MouseEnter, Label137.MouseEnter, Label136.MouseEnter, Label135.MouseEnter, Label134.MouseEnter, Label133.MouseEnter, Label132.MouseEnter, Label131.MouseEnter, Label130.MouseEnter, Label13.MouseEnter, Label129.MouseEnter, Label128.MouseEnter, Label127.MouseEnter, Label126.MouseEnter, Label125.MouseEnter, Label124.MouseEnter, Label123.MouseEnter, Label122.MouseEnter, Label121.MouseEnter, Label120.MouseEnter, Label12.MouseEnter, Label119.MouseEnter, Label118.MouseEnter, Label117.MouseEnter, Label116.MouseEnter, Label115.MouseEnter, Label114.MouseEnter, Label113.MouseEnter, Label112.MouseEnter, Label111.MouseEnter, Label110.MouseEnter, Label11.MouseEnter, Label109.MouseEnter, Label108.MouseEnter, Label107.MouseEnter, Label106.MouseEnter, Label105.MouseEnter, Label104.MouseEnter, Label103.MouseEnter, Label102.MouseEnter, Label101.MouseEnter, Label100.MouseEnter, Label10.MouseEnter, Label1.MouseEnter, Label182.MouseEnter
        MoveToStart()

    End Sub

    Private Sub Label174_Click(sender As Object, e As EventArgs) Handles Label174.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click

    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click

    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click

    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click

    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click

    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click

    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs) Handles Label35.Click

    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click

    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs) Handles Label37.Click

    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label38.Click

    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click

    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs) Handles Label41.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label40_Click(sender As Object, e As EventArgs) Handles Label40.Click

    End Sub

    Private Sub Label42_Click(sender As Object, e As EventArgs) Handles Label42.Click

    End Sub

    Private Sub Label43_Click(sender As Object, e As EventArgs) Handles Label43.Click

    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click

    End Sub

    Private Sub Label45_Click(sender As Object, e As EventArgs) Handles Label45.Click

    End Sub

    Private Sub Label46_Click(sender As Object, e As EventArgs) Handles Label46.Click

    End Sub

    Private Sub Label47_Click(sender As Object, e As EventArgs) Handles Label47.Click

    End Sub

    Private Sub Label48_Click(sender As Object, e As EventArgs) Handles Label48.Click

    End Sub

    Private Sub Label49_Click(sender As Object, e As EventArgs) Handles Label49.Click

    End Sub

    Private Sub Label51_Click(sender As Object, e As EventArgs) Handles Label51.Click

    End Sub

    Private Sub Label52_Click(sender As Object, e As EventArgs) Handles Label52.Click

    End Sub

    Private Sub Label50_Click(sender As Object, e As EventArgs) Handles Label50.Click

    End Sub

    Private Sub Label53_Click(sender As Object, e As EventArgs) Handles Label53.Click

    End Sub

    Private Sub Label54_Click(sender As Object, e As EventArgs) Handles Label54.Click

    End Sub

    Private Sub Label55_Click(sender As Object, e As EventArgs) Handles Label55.Click

    End Sub

    Private Sub Label56_Click(sender As Object, e As EventArgs) Handles Label56.Click

    End Sub

    Private Sub Label57_Click(sender As Object, e As EventArgs) Handles Label57.Click

    End Sub

    Private Sub Label58_Click(sender As Object, e As EventArgs) Handles Label58.Click

    End Sub

    Private Sub Label116_Click(sender As Object, e As EventArgs) Handles Label116.Click

    End Sub

    Private Sub Label115_Click(sender As Object, e As EventArgs) Handles Label115.Click

    End Sub

    Private Sub Label114_Click(sender As Object, e As EventArgs) Handles Label114.Click

    End Sub

    Private Sub Label113_Click(sender As Object, e As EventArgs) Handles Label113.Click

    End Sub

    Private Sub Label112_Click(sender As Object, e As EventArgs) Handles Label112.Click

    End Sub

    Private Sub Label111_Click(sender As Object, e As EventArgs) Handles Label111.Click

    End Sub

    Private Sub Label110_Click(sender As Object, e As EventArgs) Handles Label110.Click

    End Sub

    Private Sub Label109_Click(sender As Object, e As EventArgs) Handles Label109.Click

    End Sub

    Private Sub Label108_Click(sender As Object, e As EventArgs) Handles Label108.Click

    End Sub

    Private Sub Label107_Click(sender As Object, e As EventArgs) Handles Label107.Click

    End Sub

    Private Sub Label106_Click(sender As Object, e As EventArgs) Handles Label106.Click

    End Sub

    Private Sub Label105_Click(sender As Object, e As EventArgs) Handles Label105.Click

    End Sub

    Private Sub Label104_Click(sender As Object, e As EventArgs) Handles Label104.Click

    End Sub

    Private Sub Label103_Click(sender As Object, e As EventArgs) Handles Label103.Click

    End Sub

    Private Sub Label102_Click(sender As Object, e As EventArgs) Handles Label102.Click

    End Sub

    Private Sub Label101_Click(sender As Object, e As EventArgs) Handles Label101.Click

    End Sub

    Private Sub Label100_Click(sender As Object, e As EventArgs) Handles Label100.Click

    End Sub

    Private Sub Label99_Click(sender As Object, e As EventArgs) Handles Label99.Click

    End Sub

    Private Sub Label98_Click(sender As Object, e As EventArgs) Handles Label98.Click

    End Sub

    Private Sub Label97_Click(sender As Object, e As EventArgs) Handles Label97.Click

    End Sub

    Private Sub Label96_Click(sender As Object, e As EventArgs) Handles Label96.Click

    End Sub

    Private Sub Label95_Click(sender As Object, e As EventArgs) Handles Label95.Click

    End Sub

    Private Sub Label94_Click(sender As Object, e As EventArgs) Handles Label94.Click

    End Sub

    Private Sub Label93_Click(sender As Object, e As EventArgs) Handles Label93.Click

    End Sub

    Private Sub Label92_Click(sender As Object, e As EventArgs) Handles Label92.Click

    End Sub

    Private Sub Label91_Click(sender As Object, e As EventArgs) Handles Label91.Click

    End Sub

    Private Sub Label90_Click(sender As Object, e As EventArgs) Handles Label90.Click

    End Sub

    Private Sub Label89_Click(sender As Object, e As EventArgs) Handles Label89.Click

    End Sub

    Private Sub Label88_Click(sender As Object, e As EventArgs) Handles Label88.Click

    End Sub

    Private Sub Label87_Click(sender As Object, e As EventArgs) Handles Label87.Click

    End Sub

    Private Sub Label86_Click(sender As Object, e As EventArgs) Handles Label86.Click

    End Sub

    Private Sub Label85_Click(sender As Object, e As EventArgs) Handles Label85.Click

    End Sub

    Private Sub Label84_Click(sender As Object, e As EventArgs) Handles Label84.Click

    End Sub

    Private Sub Label83_Click(sender As Object, e As EventArgs) Handles Label83.Click

    End Sub

    Private Sub Label82_Click(sender As Object, e As EventArgs) Handles Label82.Click

    End Sub

    Private Sub Label81_Click(sender As Object, e As EventArgs) Handles Label81.Click

    End Sub

    Private Sub Label80_Click(sender As Object, e As EventArgs) Handles Label80.Click

    End Sub

    Private Sub Label79_Click(sender As Object, e As EventArgs) Handles Label79.Click

    End Sub

    Private Sub Label78_Click(sender As Object, e As EventArgs) Handles Label78.Click

    End Sub

    Private Sub Label77_Click(sender As Object, e As EventArgs) Handles Label77.Click

    End Sub

    Private Sub Label76_Click(sender As Object, e As EventArgs) Handles Label76.Click

    End Sub

    Private Sub Label75_Click(sender As Object, e As EventArgs) Handles Label75.Click

    End Sub

    Private Sub Label74_Click(sender As Object, e As EventArgs) Handles Label74.Click

    End Sub

    Private Sub Label73_Click(sender As Object, e As EventArgs) Handles Label73.Click

    End Sub

    Private Sub Label72_Click(sender As Object, e As EventArgs) Handles Label72.Click

    End Sub

    Private Sub Label71_Click(sender As Object, e As EventArgs) Handles Label71.Click

    End Sub

    Private Sub Label70_Click(sender As Object, e As EventArgs) Handles Label70.Click

    End Sub

    Private Sub Label69_Click(sender As Object, e As EventArgs) Handles Label69.Click

    End Sub

    Private Sub Label68_Click(sender As Object, e As EventArgs) Handles Label68.Click

    End Sub

    Private Sub Label67_Click(sender As Object, e As EventArgs) Handles Label67.Click

    End Sub

    Private Sub Label66_Click(sender As Object, e As EventArgs) Handles Label66.Click

    End Sub

    Private Sub Label65_Click(sender As Object, e As EventArgs) Handles Label65.Click

    End Sub

    Private Sub Label64_Click(sender As Object, e As EventArgs) Handles Label64.Click

    End Sub

    Private Sub Label63_Click(sender As Object, e As EventArgs) Handles Label63.Click

    End Sub

    Private Sub Label62_Click(sender As Object, e As EventArgs) Handles Label62.Click

    End Sub

    Private Sub Label61_Click(sender As Object, e As EventArgs) Handles Label61.Click

    End Sub

    Private Sub Label60_Click(sender As Object, e As EventArgs) Handles Label60.Click

    End Sub

    Private Sub Label59_Click(sender As Object, e As EventArgs) Handles Label59.Click

    End Sub

    Private Sub Label173_Click(sender As Object, e As EventArgs) Handles Label173.Click

    End Sub

    Private Sub Label172_Click(sender As Object, e As EventArgs) Handles Label172.Click

    End Sub

    Private Sub Label171_Click(sender As Object, e As EventArgs) Handles Label171.Click

    End Sub

    Private Sub Label170_Click(sender As Object, e As EventArgs) Handles Label170.Click

    End Sub

    Private Sub Label169_Click(sender As Object, e As EventArgs) Handles Label169.Click

    End Sub

    Private Sub Label168_Click(sender As Object, e As EventArgs) Handles Label168.Click

    End Sub

    Private Sub Label167_Click(sender As Object, e As EventArgs) Handles Label167.Click

    End Sub

    Private Sub Label166_Click(sender As Object, e As EventArgs) Handles Label166.Click

    End Sub

    Private Sub Label165_Click(sender As Object, e As EventArgs) Handles Label165.Click

    End Sub

    Private Sub Label164_Click(sender As Object, e As EventArgs) Handles Label164.Click

    End Sub

    Private Sub Label163_Click(sender As Object, e As EventArgs) Handles Label163.Click

    End Sub

    Private Sub Label162_Click(sender As Object, e As EventArgs) Handles Label162.Click

    End Sub

    Private Sub Label161_Click(sender As Object, e As EventArgs) Handles Label161.Click

    End Sub

    Private Sub Label160_Click(sender As Object, e As EventArgs) Handles Label160.Click

    End Sub

    Private Sub Label159_Click(sender As Object, e As EventArgs) Handles Label159.Click

    End Sub

    Private Sub Label158_Click(sender As Object, e As EventArgs) Handles Label158.Click

    End Sub

    Private Sub Label157_Click(sender As Object, e As EventArgs) Handles Label157.Click

    End Sub

    Private Sub Label156_Click(sender As Object, e As EventArgs) Handles Label156.Click

    End Sub

    Private Sub Label155_Click(sender As Object, e As EventArgs) Handles Label155.Click

    End Sub

    Private Sub Label154_Click(sender As Object, e As EventArgs) Handles Label154.Click

    End Sub

    Private Sub Label153_Click(sender As Object, e As EventArgs) Handles Label153.Click

    End Sub

    Private Sub Label152_Click(sender As Object, e As EventArgs) Handles Label152.Click

    End Sub

    Private Sub Label151_Click(sender As Object, e As EventArgs) Handles Label151.Click

    End Sub

    Private Sub Label150_Click(sender As Object, e As EventArgs) Handles Label150.Click

    End Sub

    Private Sub Label149_Click(sender As Object, e As EventArgs) Handles Label149.Click

    End Sub

    Private Sub Label148_Click(sender As Object, e As EventArgs) Handles Label148.Click

    End Sub

    Private Sub Label147_Click(sender As Object, e As EventArgs) Handles Label147.Click

    End Sub

    Private Sub Label146_Click(sender As Object, e As EventArgs) Handles Label146.Click

    End Sub

    Private Sub Label145_Click(sender As Object, e As EventArgs) Handles Label145.Click

    End Sub

    Private Sub Label144_Click(sender As Object, e As EventArgs) Handles Label144.Click

    End Sub

    Private Sub Label143_Click(sender As Object, e As EventArgs) Handles Label143.Click

    End Sub

    Private Sub Label142_Click(sender As Object, e As EventArgs) Handles Label142.Click

    End Sub

    Private Sub Label141_Click(sender As Object, e As EventArgs) Handles Label141.Click

    End Sub

    Private Sub Label140_Click(sender As Object, e As EventArgs) Handles Label140.Click

    End Sub

    Private Sub Label139_Click(sender As Object, e As EventArgs) Handles Label139.Click

    End Sub

    Private Sub Label138_Click(sender As Object, e As EventArgs) Handles Label138.Click

    End Sub

    Private Sub Label137_Click(sender As Object, e As EventArgs) Handles Label137.Click

    End Sub

    Private Sub Label136_Click(sender As Object, e As EventArgs) Handles Label136.Click

    End Sub

    Private Sub Label135_Click(sender As Object, e As EventArgs) Handles Label135.Click

    End Sub

    Private Sub Label134_Click(sender As Object, e As EventArgs) Handles Label134.Click

    End Sub

    Private Sub Label133_Click(sender As Object, e As EventArgs) Handles Label133.Click

    End Sub

    Private Sub Label132_Click(sender As Object, e As EventArgs) Handles Label132.Click

    End Sub

    Private Sub Label131_Click(sender As Object, e As EventArgs) Handles Label131.Click

    End Sub

    Private Sub Label130_Click(sender As Object, e As EventArgs) Handles Label130.Click

    End Sub

    Private Sub Label129_Click(sender As Object, e As EventArgs) Handles Label129.Click

    End Sub

    Private Sub Label128_Click(sender As Object, e As EventArgs) Handles Label128.Click

    End Sub

    Private Sub Label127_Click(sender As Object, e As EventArgs) Handles Label127.Click

    End Sub

    Private Sub Label126_Click(sender As Object, e As EventArgs) Handles Label126.Click

    End Sub

    Private Sub Label125_Click(sender As Object, e As EventArgs) Handles Label125.Click

    End Sub

    Private Sub Label124_Click(sender As Object, e As EventArgs) Handles Label124.Click

    End Sub

    Private Sub Label123_Click(sender As Object, e As EventArgs) Handles Label123.Click

    End Sub

    Private Sub Label122_Click(sender As Object, e As EventArgs) Handles Label122.Click

    End Sub

    Private Sub Label121_Click(sender As Object, e As EventArgs) Handles Label121.Click

    End Sub

    Private Sub Label120_Click(sender As Object, e As EventArgs) Handles Label120.Click

    End Sub

    Private Sub Label119_Click(sender As Object, e As EventArgs) Handles Label119.Click

    End Sub

    Private Sub Label118_Click(sender As Object, e As EventArgs) Handles Label118.Click

    End Sub

    Private Sub Label117_Click(sender As Object, e As EventArgs) Handles Label117.Click

    End Sub

    Private Sub Label175_Click(sender As Object, e As EventArgs) Handles Label175.Click

    End Sub

    Private Sub Label176_Click(sender As Object, e As EventArgs) Handles Label176.Click

    End Sub

    Private Sub Label177_Click(sender As Object, e As EventArgs) Handles Label177.Click

    End Sub

    Private Sub Label180_Click(sender As Object, e As EventArgs) Handles Label180.Click

    End Sub

    Private Sub Label181_Click(sender As Object, e As EventArgs) Handles Label181.Click

    End Sub

    Private Sub Label178_Click(sender As Object, e As EventArgs) Handles Label178.Click

    End Sub

    Private Sub Label179_Click(sender As Object, e As EventArgs) Handles Label179.Click

    End Sub

    Private Sub Label183_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label182_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MessageBox.Show("U win...4 now")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        MoveToStart()

    End Sub
    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) _
                                               Handles Panel3.MouseDown
        Panel3.Capture = False
    End Sub

End Class
