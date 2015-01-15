Public Class Form1
    'Seulement les stations et les lignes appropriees sont activees. La partie "calcul" n'est pas visible. C'est long mais pas complique!
    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb7.Enabled = False : tb8.Enabled = False : tb9.Enabled = False : tb10.Enabled = False : tb23.Enabled = False : tb24.Enabled = False : tb25.Enabled = False : tb26.Enabled = False : tb27.Enabled = False : tb28.Enabled = False : tb29.Enabled = False : tb30.Enabled = False : tb36.Enabled = False : tb37.Enabled = False : tb38.Enabled = False : tb39.Enabled = False : tb40.Enabled = False : tb51.Enabled = False : tb52.Enabled = False : tb53.Enabled = False : tb54.Enabled = False : tb55.Enabled = False : tb56.Enabled = False : tb57.Enabled = False : tb58.Enabled = False : tb59.Enabled = False : tb60.Enabled = False : tb66.Enabled = False : tb67.Enabled = False : tb68.Enabled = False : tb69.Enabled = False : tb70.Enabled = False : tb81.Enabled = False : tb82.Enabled = False : tb83.Enabled = False : tb84.Enabled = False : tb85.Enabled = False : tb86.Enabled = False : tb87.Enabled = False : tb88.Enabled = False : tb89.Enabled = False : tb90.Enabled = False : tb91.Enabled = False : tb92.Enabled = False : tb93.Enabled = False : tb94.Enabled = False : tb95.Enabled = False : tb96.Enabled = False : tb97.Enabled = False : tb98.Enabled = False : tb99.Enabled = False : tb100.Enabled = False : tb101.Enabled = False : tb102.Enabled = False : tb103.Enabled = False : tb104.Enabled = False : tb105.Enabled = False : tb106.Enabled = False : tb107.Enabled = False : tb108.Enabled = False : tb109.Enabled = False : tb110.Enabled = False : tb111.Enabled = False : tb112.Enabled = False : tb113.Enabled = False : tb114.Enabled = False : tb115.Enabled = False : tb116.Enabled = False : tb117.Enabled = False : tb118.Enabled = False : tb119.Enabled = False : tb120.Enabled = False : tb121.Enabled = False : tb122.Enabled = False : tb123.Enabled = False : tb124.Enabled = False : tb125.Enabled = False : tb126.Enabled = False : tb127.Enabled = False : tb128.Enabled = False : tb129.Enabled = False : tb130.Enabled = False : tb131.Enabled = False : tb132.Enabled = False : tb133.Enabled = False : tb134.Enabled = False : tb135.Enabled = False : tb136.Enabled = False : tb137.Enabled = False : tb138.Enabled = False : tb139.Enabled = False : tb140.Enabled = False : tb141.Enabled = False : tb142.Enabled = False : tb143.Enabled = False : tb144.Enabled = False : tb145.Enabled = False : tb146.Enabled = False : tb147.Enabled = False : tb148.Enabled = False : tb149.Enabled = False : tb150.Enabled = False : tb154.Enabled = False : tb155.Enabled = False : Button14.Enabled = False : Button13.Enabled = False : Button12.Enabled = False : Button11.Enabled = False : Label5.Enabled = False : Label6.Enabled = False
        Label7.Visible = False : Label8.Visible = False : Label9.Visible = False : Label10.Visible = False : Label11.Visible = False : Label12.Visible = False : Label13.Visible = False : Label14.Visible = False : Label15.Visible = False : Label16.Visible = False : Label18.Visible = False : Label19.Visible = False
        ComboBox1.Visible = False : ComboBox2.Visible = False : ComboBox3.Visible = False : ComboBox4.Visible = False : ComboBox5.Visible = False : ComboBox6.Visible = False : ComboBox7.Visible = False : ComboBox8.Visible = False : ComboBox9.Visible = False : ComboBox10.Visible = False
        Button2.Visible = False : Button16.Visible = False : Button17.Visible = False : Button18.Visible = False : Button19.Visible = False : Button15.Visible = False : Button20.Visible = False
        ListBox1.Visible = False
    End Sub
    'Ajouter une ligne
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Message d'erreur
        If Label1.Text = 5 Then Beep() : MsgBox("Pas plus de 5 lignes.") : Label1.Text = Label1.Text - 1

        Label1.Text = Label1.Text + 1
        'On active les lignes en tenant compte de l'incrementation du nombre de lignes.
        If Label1.Text = 5 Then tb155.Enabled = True : Button14.Enabled = True : Button13.Enabled = True : Label6.Enabled = True : Label6.Text = 1 : tb121.Enabled = True : tb131.Enabled = True : tb132.Enabled = True

        If Label1.Text = 4 Then tb154.Enabled = True : Button12.Enabled = True : Button11.Enabled = True : Label5.Enabled = True : Label5.Text = 1 : tb91.Enabled = True : tb101.Enabled = True : tb102.Enabled = True

        If Label1.Text = 3 Then tb153.Enabled = True : Button10.Enabled = True : Button9.Enabled = True : Label4.Enabled = True : Label4.Text = 1 : tb61.Enabled = True : tb71.Enabled = True : tb72.Enabled = True

        If Label1.Text = 2 Then tb152.Enabled = True : Button8.Enabled = True : Button7.Enabled = True : Label3.Enabled = True : Label3.Text = 1 : tb31.Enabled = True : tb41.Enabled = True : tb42.Enabled = True
    End Sub
    'Pareil mais pour le bouton "-"
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If Label1.Text = 1 Then Beep() : MsgBox("Il faut au moins une ligne de metro.") : Label1.Text = Label1.Text + 1
        Label1.Text = Label1.Text - 1
        

        If Label1.Text < 5 Then tb155.Enabled = False : Button14.Enabled = False : Button13.Enabled = False : Label6.Enabled = False : tb121.Enabled = False : tb122.Enabled = False : tb123.Enabled = False : tb124.Enabled = False : tb125.Enabled = False : tb126.Enabled = False : tb127.Enabled = False : tb128.Enabled = False : tb129.Enabled = False : tb130.Enabled = False : tb131.Enabled = False : tb132.Enabled = False : tb133.Enabled = False : tb134.Enabled = False : tb135.Enabled = False : tb136.Enabled = False : tb137.Enabled = False : tb138.Enabled = False : tb139.Enabled = False : tb140.Enabled = False : tb141.Enabled = False : tb142.Enabled = False : tb143.Enabled = False : tb144.Enabled = False : tb145.Enabled = False : tb146.Enabled = False : tb147.Enabled = False : tb148.Enabled = False : tb149.Enabled = False : tb150.Enabled = False

        If Label1.Text < 4 Then tb154.Enabled = False : Button12.Enabled = False : Button11.Enabled = False : Label5.Enabled = False : tb91.Enabled = False : tb92.Enabled = False : tb93.Enabled = False : tb94.Enabled = False : tb95.Enabled = False : tb96.Enabled = False : tb97.Enabled = False : tb98.Enabled = False : tb99.Enabled = False : tb100.Enabled = False : tb101.Enabled = False : tb102.Enabled = False : tb103.Enabled = False : tb104.Enabled = False : tb105.Enabled = False : tb106.Enabled = False : tb107.Enabled = False : tb108.Enabled = False : tb109.Enabled = False : tb110.Enabled = False : tb111.Enabled = False : tb112.Enabled = False : tb113.Enabled = False : tb114.Enabled = False : tb115.Enabled = False : tb116.Enabled = False : tb117.Enabled = False : tb118.Enabled = False : tb119.Enabled = False : tb120.Enabled = False

        If Label1.Text < 3 Then tb153.Enabled = False : Button10.Enabled = False : Button9.Enabled = False : Label4.Enabled = False : tb61.Enabled = False : tb62.Enabled = False : tb63.Enabled = False : tb64.Enabled = False : tb65.Enabled = False : tb66.Enabled = False : tb67.Enabled = False : tb68.Enabled = False : tb69.Enabled = False : tb70.Enabled = False : tb71.Enabled = False : tb72.Enabled = False : tb73.Enabled = False : tb74.Enabled = False : tb75.Enabled = False : tb76.Enabled = False : tb77.Enabled = False : tb78.Enabled = False : tb79.Enabled = False : tb80.Enabled = False : tb81.Enabled = False : tb82.Enabled = False : tb83.Enabled = False : tb84.Enabled = False : tb85.Enabled = False : tb86.Enabled = False : tb87.Enabled = False : tb88.Enabled = False : tb89.Enabled = False : tb90.Enabled = False
        'La raison pour laquelle il n'y a pas cette ligne pour le bouton "+" est qu'on ne peut pas "passer" au terme 1 en augmentant, en effet 1 est le minimum du nombre de lignes possibles
        If Label1.Text < 2 Then tb152.Enabled = False : Button8.Enabled = False : Button7.Enabled = False : Label3.Enabled = False : tb31.Enabled = False : tb32.Enabled = False : tb33.Enabled = False : tb34.Enabled = False : tb35.Enabled = False : tb36.Enabled = False : tb37.Enabled = False : tb38.Enabled = False : tb39.Enabled = False : tb40.Enabled = False : tb41.Enabled = False : tb42.Enabled = False : tb43.Enabled = False : tb44.Enabled = False : tb45.Enabled = False : tb46.Enabled = False : tb47.Enabled = False : tb48.Enabled = False : tb49.Enabled = False : tb50.Enabled = False : tb51.Enabled = False : tb52.Enabled = False : tb53.Enabled = False : tb54.Enabled = False : tb55.Enabled = False : tb56.Enabled = False : tb57.Enabled = False : tb58.Enabled = False : tb59.Enabled = False : tb60.Enabled = False
    End Sub
    'Ajouter une station a la ligne 1
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Message d'erreur si on veut plus de 10 stations
        If Label2.Text = 10 Then Beep() : MsgBox("Pas plus de 10 stations.") : Label2.Text = Label2.Text - 1
        Label2.Text = Label2.Text + 1
        tb1.Enabled = True : tb2.Enabled = True : tb3.Enabled = True : tb4.Enabled = True : tb5.Enabled = True : tb6.Enabled = True : tb7.Enabled = True : tb8.Enabled = True : tb9.Enabled = True : tb10.Enabled = True : tb11.Enabled = True : tb12.Enabled = True : tb13.Enabled = True : tb14.Enabled = True : tb15.Enabled = True : tb16.Enabled = True : tb17.Enabled = True : tb18.Enabled = True : tb19.Enabled = True : tb20.Enabled = True : tb21.Enabled = True : tb22.Enabled = True : tb23.Enabled = True : tb24.Enabled = True : tb25.Enabled = True : tb26.Enabled = True : tb27.Enabled = True : tb28.Enabled = True : tb29.Enabled = True : tb30.Enabled = True
        If Label2.Text < 10 Then tb10.Enabled = False : tb29.Enabled = False : tb30.Enabled = False
        If Label2.Text < 9 Then tb9.Enabled = False : tb27.Enabled = False : tb28.Enabled = False
        If Label2.Text < 8 Then tb8.Enabled = False : tb25.Enabled = False : tb26.Enabled = False
        If Label2.Text < 7 Then tb7.Enabled = False : tb23.Enabled = False : tb24.Enabled = False
        If Label2.Text < 6 Then tb6.Enabled = False : tb21.Enabled = False : tb22.Enabled = False
        If Label2.Text < 5 Then tb5.Enabled = False : tb19.Enabled = False : tb20.Enabled = False
        If Label2.Text < 4 Then tb4.Enabled = False : tb17.Enabled = False : tb18.Enabled = False
        If Label2.Text < 3 Then tb3.Enabled = False : tb15.Enabled = False : tb16.Enabled = False
    End Sub
    'Enlever une station a la ligne 1
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Message d'erreur si on veut moins de 1 station
        If Label2.Text = 1 Then Beep() : MsgBox("Au moins une station.") : Label2.Text = Label2.Text + 1
        Label2.Text = Label2.Text - 1
        tb1.Enabled = True : tb2.Enabled = True : tb3.Enabled = True : tb4.Enabled = True : tb5.Enabled = True : tb6.Enabled = True : tb7.Enabled = True : tb8.Enabled = True : tb9.Enabled = True : tb10.Enabled = True : tb11.Enabled = True : tb12.Enabled = True : tb13.Enabled = True : tb14.Enabled = True : tb15.Enabled = True : tb16.Enabled = True : tb17.Enabled = True : tb18.Enabled = True : tb19.Enabled = True : tb20.Enabled = True : tb21.Enabled = True : tb22.Enabled = True : tb23.Enabled = True : tb24.Enabled = True : tb25.Enabled = True : tb26.Enabled = True : tb27.Enabled = True : tb28.Enabled = True : tb29.Enabled = True : tb30.Enabled = True
        If Label2.Text < 10 Then tb10.Enabled = False : tb29.Enabled = False : tb30.Enabled = False
        If Label2.Text < 9 Then tb9.Enabled = False : tb27.Enabled = False : tb28.Enabled = False
        If Label2.Text < 8 Then tb8.Enabled = False : tb25.Enabled = False : tb26.Enabled = False
        If Label2.Text < 7 Then tb7.Enabled = False : tb23.Enabled = False : tb24.Enabled = False
        If Label2.Text < 6 Then tb6.Enabled = False : tb21.Enabled = False : tb22.Enabled = False
        If Label2.Text < 5 Then tb5.Enabled = False : tb19.Enabled = False : tb20.Enabled = False
        If Label2.Text < 4 Then tb4.Enabled = False : tb17.Enabled = False : tb18.Enabled = False
        If Label2.Text < 3 Then tb3.Enabled = False : tb15.Enabled = False : tb16.Enabled = False
        If Label2.Text < 2 Then tb2.Enabled = False : tb13.Enabled = False : tb14.Enabled = False
    End Sub
    'add2
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Label3.Text = 10 Then Beep() : MsgBox("Pas plus de 10 stations.") : Label3.Text = Label3.Text - 1
        Label3.Text = Label3.Text + 1
        tb31.Enabled = True : tb32.Enabled = True : tb33.Enabled = True : tb34.Enabled = True : tb35.Enabled = True : tb36.Enabled = True : tb37.Enabled = True : tb38.Enabled = True : tb39.Enabled = True : tb40.Enabled = True : tb41.Enabled = True : tb42.Enabled = True : tb43.Enabled = True : tb44.Enabled = True : tb45.Enabled = True : tb46.Enabled = True : tb47.Enabled = True : tb48.Enabled = True : tb49.Enabled = True : tb50.Enabled = True : tb51.Enabled = True : tb52.Enabled = True : tb53.Enabled = True : tb54.Enabled = True : tb55.Enabled = True : tb56.Enabled = True : tb57.Enabled = True : tb58.Enabled = True : tb59.Enabled = True : tb60.Enabled = True
        If Label3.Text < 10 Then tb40.Enabled = False : tb59.Enabled = False : tb60.Enabled = False
        If Label3.Text < 9 Then tb39.Enabled = False : tb57.Enabled = False : tb58.Enabled = False
        If Label3.Text < 8 Then tb38.Enabled = False : tb55.Enabled = False : tb56.Enabled = False
        If Label3.Text < 7 Then tb37.Enabled = False : tb53.Enabled = False : tb54.Enabled = False
        If Label3.Text < 6 Then tb36.Enabled = False : tb51.Enabled = False : tb52.Enabled = False
        If Label3.Text < 5 Then tb35.Enabled = False : tb49.Enabled = False : tb50.Enabled = False
        If Label3.Text < 4 Then tb34.Enabled = False : tb47.Enabled = False : tb48.Enabled = False
        If Label3.Text < 3 Then tb33.Enabled = False : tb45.Enabled = False : tb46.Enabled = False
    End Sub
    'sup2
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Label3.Text = 1 Then Beep() : MsgBox("Au moins une station.") : Label3.Text = Label3.Text + 1
        Label3.Text = Label3.Text - 1
        tb31.Enabled = True : tb32.Enabled = True : tb33.Enabled = True : tb34.Enabled = True : tb35.Enabled = True : tb36.Enabled = True : tb37.Enabled = True : tb38.Enabled = True : tb39.Enabled = True : tb40.Enabled = True : tb41.Enabled = True : tb42.Enabled = True : tb43.Enabled = True : tb44.Enabled = True : tb45.Enabled = True : tb46.Enabled = True : tb47.Enabled = True : tb48.Enabled = True : tb49.Enabled = True : tb50.Enabled = True : tb51.Enabled = True : tb52.Enabled = True : tb53.Enabled = True : tb54.Enabled = True : tb55.Enabled = True : tb56.Enabled = True : tb57.Enabled = True : tb58.Enabled = True : tb59.Enabled = True : tb60.Enabled = True
        If Label3.Text < 10 Then tb40.Enabled = False : tb59.Enabled = False : tb60.Enabled = False
        If Label3.Text < 9 Then tb39.Enabled = False : tb57.Enabled = False : tb58.Enabled = False
        If Label3.Text < 8 Then tb38.Enabled = False : tb55.Enabled = False : tb56.Enabled = False
        If Label3.Text < 7 Then tb37.Enabled = False : tb53.Enabled = False : tb54.Enabled = False
        If Label3.Text < 6 Then tb36.Enabled = False : tb51.Enabled = False : tb52.Enabled = False
        If Label3.Text < 5 Then tb35.Enabled = False : tb49.Enabled = False : tb50.Enabled = False
        If Label3.Text < 4 Then tb34.Enabled = False : tb47.Enabled = False : tb48.Enabled = False
        If Label3.Text < 3 Then tb33.Enabled = False : tb45.Enabled = False : tb46.Enabled = False
        If Label3.Text < 2 Then tb32.Enabled = False : tb43.Enabled = False : tb44.Enabled = False
    End Sub
    'add3
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If Label4.Text = 10 Then Beep() : MsgBox("Pas plus de 10 stations.") : Label4.Text = Label4.Text - 1
        Label4.Text = Label4.Text + 1
        tb61.Enabled = True : tb62.Enabled = True : tb63.Enabled = True : tb64.Enabled = True : tb65.Enabled = True : tb66.Enabled = True : tb67.Enabled = True : tb68.Enabled = True : tb69.Enabled = True : tb70.Enabled = True : tb71.Enabled = True : tb72.Enabled = True : tb73.Enabled = True : tb74.Enabled = True : tb75.Enabled = True : tb76.Enabled = True : tb77.Enabled = True : tb78.Enabled = True : tb79.Enabled = True : tb80.Enabled = True : tb81.Enabled = True : tb82.Enabled = True : tb83.Enabled = True : tb84.Enabled = True : tb85.Enabled = True : tb86.Enabled = True : tb87.Enabled = True : tb88.Enabled = True : tb89.Enabled = True : tb90.Enabled = True
        If Label4.Text < 10 Then tb70.Enabled = False : tb89.Enabled = False : tb90.Enabled = False
        If Label4.Text < 9 Then tb69.Enabled = False : tb87.Enabled = False : tb88.Enabled = False
        If Label4.Text < 8 Then tb68.Enabled = False : tb85.Enabled = False : tb86.Enabled = False
        If Label4.Text < 7 Then tb67.Enabled = False : tb83.Enabled = False : tb84.Enabled = False
        If Label4.Text < 6 Then tb66.Enabled = False : tb81.Enabled = False : tb82.Enabled = False
        If Label4.Text < 5 Then tb65.Enabled = False : tb79.Enabled = False : tb80.Enabled = False
        If Label4.Text < 4 Then tb64.Enabled = False : tb77.Enabled = False : tb78.Enabled = False
        If Label4.Text < 3 Then tb63.Enabled = False : tb75.Enabled = False : tb76.Enabled = False
    End Sub
    'sup3
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Label4.Text = 1 Then Beep() : MsgBox("Au moins une station.") : Label4.Text = Label4.Text + 1
        Label4.Text = Label4.Text - 1
        tb61.Enabled = True : tb62.Enabled = True : tb63.Enabled = True : tb64.Enabled = True : tb65.Enabled = True : tb66.Enabled = True : tb67.Enabled = True : tb68.Enabled = True : tb69.Enabled = True : tb70.Enabled = True : tb71.Enabled = True : tb72.Enabled = True : tb73.Enabled = True : tb74.Enabled = True : tb75.Enabled = True : tb76.Enabled = True : tb77.Enabled = True : tb78.Enabled = True : tb79.Enabled = True : tb80.Enabled = True : tb81.Enabled = True : tb82.Enabled = True : tb83.Enabled = True : tb84.Enabled = True : tb85.Enabled = True : tb86.Enabled = True : tb87.Enabled = True : tb88.Enabled = True : tb89.Enabled = True : tb90.Enabled = True
        If Label4.Text < 10 Then tb70.Enabled = False : tb89.Enabled = False : tb90.Enabled = False
        If Label4.Text < 9 Then tb69.Enabled = False : tb87.Enabled = False : tb88.Enabled = False
        If Label4.Text < 8 Then tb68.Enabled = False : tb85.Enabled = False : tb86.Enabled = False
        If Label4.Text < 7 Then tb67.Enabled = False : tb83.Enabled = False : tb84.Enabled = False
        If Label4.Text < 6 Then tb66.Enabled = False : tb81.Enabled = False : tb82.Enabled = False
        If Label4.Text < 5 Then tb65.Enabled = False : tb79.Enabled = False : tb80.Enabled = False
        If Label4.Text < 4 Then tb64.Enabled = False : tb77.Enabled = False : tb78.Enabled = False
        If Label4.Text < 3 Then tb63.Enabled = False : tb75.Enabled = False : tb76.Enabled = False
        If Label4.Text < 2 Then tb62.Enabled = False : tb73.Enabled = False : tb74.Enabled = False
    End Sub
    'add4
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If Label5.Text = 10 Then Beep() : MsgBox("Pas plus de 10 stations.") : Label5.Text = Label5.Text - 1
        Label5.Text = Label5.Text + 1
        tb91.Enabled = True : tb92.Enabled = True : tb93.Enabled = True : tb94.Enabled = True : tb95.Enabled = True : tb96.Enabled = True : tb97.Enabled = True : tb98.Enabled = True : tb99.Enabled = True : tb100.Enabled = True : tb101.Enabled = True : tb102.Enabled = True : tb103.Enabled = True : tb104.Enabled = True : tb105.Enabled = True : tb106.Enabled = True : tb107.Enabled = True : tb108.Enabled = True : tb109.Enabled = True : tb110.Enabled = True : tb111.Enabled = True : tb112.Enabled = True : tb113.Enabled = True : tb114.Enabled = True : tb115.Enabled = True : tb116.Enabled = True : tb117.Enabled = True : tb118.Enabled = True : tb119.Enabled = True : tb120.Enabled = True
        If Label5.Text < 10 Then tb100.Enabled = False : tb119.Enabled = False : tb120.Enabled = False
        If Label5.Text < 9 Then tb99.Enabled = False : tb117.Enabled = False : tb118.Enabled = False
        If Label5.Text < 8 Then tb98.Enabled = False : tb115.Enabled = False : tb116.Enabled = False
        If Label5.Text < 7 Then tb97.Enabled = False : tb113.Enabled = False : tb114.Enabled = False
        If Label5.Text < 6 Then tb96.Enabled = False : tb111.Enabled = False : tb112.Enabled = False
        If Label5.Text < 5 Then tb95.Enabled = False : tb109.Enabled = False : tb110.Enabled = False
        If Label5.Text < 4 Then tb94.Enabled = False : tb107.Enabled = False : tb108.Enabled = False
        If Label5.Text < 3 Then tb93.Enabled = False : tb105.Enabled = False : tb106.Enabled = False
    End Sub
    'sup4
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If Label5.Text = 1 Then Beep() : MsgBox("Au moins une station.") : Label5.Text = Label5.Text + 1
        Label5.Text = Label5.Text - 1
        tb91.Enabled = True : tb92.Enabled = True : tb93.Enabled = True : tb94.Enabled = True : tb95.Enabled = True : tb96.Enabled = True : tb97.Enabled = True : tb98.Enabled = True : tb99.Enabled = True : tb100.Enabled = True : tb101.Enabled = True : tb102.Enabled = True : tb103.Enabled = True : tb104.Enabled = True : tb105.Enabled = True : tb106.Enabled = True : tb107.Enabled = True : tb108.Enabled = True : tb109.Enabled = True : tb110.Enabled = True : tb111.Enabled = True : tb112.Enabled = True : tb113.Enabled = True : tb114.Enabled = True : tb115.Enabled = True : tb116.Enabled = True : tb117.Enabled = True : tb118.Enabled = True : tb119.Enabled = True : tb120.Enabled = True
        If Label5.Text < 10 Then tb100.Enabled = False : tb119.Enabled = False : tb120.Enabled = False
        If Label5.Text < 9 Then tb99.Enabled = False : tb117.Enabled = False : tb118.Enabled = False
        If Label5.Text < 8 Then tb98.Enabled = False : tb115.Enabled = False : tb116.Enabled = False
        If Label5.Text < 7 Then tb97.Enabled = False : tb113.Enabled = False : tb114.Enabled = False
        If Label5.Text < 6 Then tb96.Enabled = False : tb111.Enabled = False : tb112.Enabled = False
        If Label5.Text < 5 Then tb95.Enabled = False : tb109.Enabled = False : tb110.Enabled = False
        If Label5.Text < 4 Then tb94.Enabled = False : tb107.Enabled = False : tb108.Enabled = False
        If Label5.Text < 3 Then tb93.Enabled = False : tb105.Enabled = False : tb106.Enabled = False
        If Label5.Text < 2 Then tb92.Enabled = False : tb103.Enabled = False : tb104.Enabled = False
    End Sub
    'add5
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If Label6.Text = 10 Then Beep() : MsgBox("Pas plus de 10 stations.") : Label6.Text = Label6.Text - 1
        Label6.Text = Label6.Text + 1
        tb121.Enabled = True : tb122.Enabled = True : tb123.Enabled = True : tb124.Enabled = True : tb125.Enabled = True : tb126.Enabled = True : tb127.Enabled = True : tb128.Enabled = True : tb129.Enabled = True : tb130.Enabled = True : tb131.Enabled = True : tb132.Enabled = True : tb133.Enabled = True : tb134.Enabled = True : tb135.Enabled = True : tb136.Enabled = True : tb137.Enabled = True : tb138.Enabled = True : tb139.Enabled = True : tb140.Enabled = True : tb141.Enabled = True : tb142.Enabled = True : tb143.Enabled = True : tb144.Enabled = True : tb145.Enabled = True : tb146.Enabled = True : tb147.Enabled = True : tb148.Enabled = True : tb149.Enabled = True : tb150.Enabled = True
        If Label6.Text < 10 Then tb130.Enabled = False : tb149.Enabled = False : tb150.Enabled = False
        If Label6.Text < 9 Then tb129.Enabled = False : tb147.Enabled = False : tb148.Enabled = False
        If Label6.Text < 8 Then tb128.Enabled = False : tb145.Enabled = False : tb146.Enabled = False
        If Label6.Text < 7 Then tb127.Enabled = False : tb143.Enabled = False : tb144.Enabled = False
        If Label6.Text < 6 Then tb126.Enabled = False : tb141.Enabled = False : tb142.Enabled = False
        If Label6.Text < 5 Then tb125.Enabled = False : tb139.Enabled = False : tb140.Enabled = False
        If Label6.Text < 4 Then tb124.Enabled = False : tb137.Enabled = False : tb138.Enabled = False
        If Label6.Text < 3 Then tb123.Enabled = False : tb135.Enabled = False : tb136.Enabled = False
    End Sub
    'sup5
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If Label6.Text = 1 Then Beep() : MsgBox("Au moins une station.") : Label6.Text = Label6.Text + 1
        Label6.Text = Label6.Text - 1
        tb121.Enabled = True : tb122.Enabled = True : tb123.Enabled = True : tb124.Enabled = True : tb125.Enabled = True : tb126.Enabled = True : tb127.Enabled = True : tb128.Enabled = True : tb129.Enabled = True : tb130.Enabled = True : tb131.Enabled = True : tb132.Enabled = True : tb133.Enabled = True : tb134.Enabled = True : tb135.Enabled = True : tb136.Enabled = True : tb137.Enabled = True : tb138.Enabled = True : tb139.Enabled = True : tb140.Enabled = True : tb141.Enabled = True : tb142.Enabled = True : tb143.Enabled = True : tb144.Enabled = True : tb145.Enabled = True : tb146.Enabled = True : tb147.Enabled = True : tb148.Enabled = True : tb149.Enabled = True : tb150.Enabled = True
        If Label6.Text < 10 Then tb130.Enabled = False : tb149.Enabled = False : tb150.Enabled = False
        If Label6.Text < 9 Then tb129.Enabled = False : tb147.Enabled = False : tb148.Enabled = False
        If Label6.Text < 8 Then tb128.Enabled = False : tb145.Enabled = False : tb146.Enabled = False
        If Label6.Text < 7 Then tb127.Enabled = False : tb143.Enabled = False : tb144.Enabled = False
        If Label6.Text < 6 Then tb126.Enabled = False : tb141.Enabled = False : tb142.Enabled = False
        If Label6.Text < 5 Then tb125.Enabled = False : tb139.Enabled = False : tb140.Enabled = False
        If Label6.Text < 4 Then tb124.Enabled = False : tb137.Enabled = False : tb138.Enabled = False
        If Label6.Text < 3 Then tb123.Enabled = False : tb135.Enabled = False : tb136.Enabled = False
        If Label6.Text < 2 Then tb122.Enabled = False : tb133.Enabled = False : tb134.Enabled = False
    End Sub
    'Passer a la partie "calcul"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'On active la partie "calcul"
        Panel2.Visible = True

        Label7.Visible = False : Label8.Visible = False : Label9.Visible = False : Label10.Visible = False : Label11.Visible = False : Label12.Visible = False : Label13.Visible = False : Label14.Visible = False : Label15.Visible = False : Label16.Visible = False : Label18.Visible = True : Label19.Visible = True
        ComboBox1.Visible = False : ComboBox2.Visible = False : ComboBox3.Visible = False : ComboBox4.Visible = False : ComboBox5.Visible = False : ComboBox6.Visible = False : ComboBox7.Visible = False : ComboBox8.Visible = False : ComboBox9.Visible = False : ComboBox10.Visible = False
        Button2.Visible = False : Button16.Visible = False : Button17.Visible = False : Button18.Visible = False : Button19.Visible = False : Button15.Visible = True : Button20.Visible = True
        ListBox1.Visible = True
        Label19.Text = 0 : Label7.Text = 0 : Label8.Text = 0 : Label9.Text = 0 : Label10.Text = 0 : Label11.Text = 0
        ListBox1.Items.Clear()
        'On masque la partie "traitement"
        Panel1.Visible = False
        'On active les calculs de lignes par rapport au nombre de lignes voulu
        Label12.Visible = True : ComboBox1.Visible = True : ComboBox2.Visible = True : Button2.Visible = True : Label7.Visible = True
        If Label1.Text > 1 Then Label13.Visible = True : ComboBox3.Visible = True : ComboBox4.Visible = True : Button16.Visible = True : Label8.Visible = True
        If Label1.Text > 2 Then Label14.Visible = True : ComboBox5.Visible = True : ComboBox6.Visible = True : Button17.Visible = True : Label9.Visible = True
        If Label1.Text > 3 Then Label15.Visible = True : ComboBox7.Visible = True : ComboBox8.Visible = True : Button18.Visible = True : Label10.Visible = True
        If Label1.Text > 4 Then Label16.Visible = True : ComboBox9.Visible = True : ComboBox10.Visible = True : Button19.Visible = True : Label11.Visible = True

        Label12.Text = tb151.Text
        Label13.Text = tb152.Text
        Label14.Text = tb153.Text
        Label15.Text = tb154.Text
        Label16.Text = tb155.Text

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox5.Items.Clear()
        ComboBox6.Items.Clear()
        ComboBox7.Items.Clear()
        ComboBox8.Items.Clear()
        ComboBox9.Items.Clear()
        ComboBox10.Items.Clear()
        'On ajoute des stations aux combobox
        If tb1.Enabled = True Then ComboBox1.Items.Add(tb1.Text)
        If tb2.Enabled = True Then ComboBox1.Items.Add(tb2.Text)
        If tb3.Enabled = True Then ComboBox1.Items.Add(tb3.Text)
        If tb4.Enabled = True Then ComboBox1.Items.Add(tb4.Text)
        If tb5.Enabled = True Then ComboBox1.Items.Add(tb5.Text)
        If tb6.Enabled = True Then ComboBox1.Items.Add(tb6.Text)
        If tb7.Enabled = True Then ComboBox1.Items.Add(tb7.Text)
        If tb8.Enabled = True Then ComboBox1.Items.Add(tb8.Text)
        If tb9.Enabled = True Then ComboBox1.Items.Add(tb9.Text)
        If tb10.Enabled = True Then ComboBox1.Items.Add(tb10.Text)

        If tb31.Enabled = True Then ComboBox3.Items.Add(tb31.Text)
        If tb32.Enabled = True Then ComboBox3.Items.Add(tb32.Text)
        If tb33.Enabled = True Then ComboBox3.Items.Add(tb33.Text)
        If tb34.Enabled = True Then ComboBox3.Items.Add(tb34.Text)
        If tb35.Enabled = True Then ComboBox3.Items.Add(tb35.Text)
        If tb36.Enabled = True Then ComboBox3.Items.Add(tb36.Text)
        If tb37.Enabled = True Then ComboBox3.Items.Add(tb37.Text)
        If tb38.Enabled = True Then ComboBox3.Items.Add(tb38.Text)
        If tb39.Enabled = True Then ComboBox3.Items.Add(tb39.Text)
        If tb40.Enabled = True Then ComboBox3.Items.Add(tb40.Text)

        If tb61.Enabled = True Then ComboBox5.Items.Add(tb61.Text)
        If tb62.Enabled = True Then ComboBox5.Items.Add(tb62.Text)
        If tb63.Enabled = True Then ComboBox5.Items.Add(tb63.Text)
        If tb64.Enabled = True Then ComboBox5.Items.Add(tb64.Text)
        If tb65.Enabled = True Then ComboBox5.Items.Add(tb65.Text)
        If tb66.Enabled = True Then ComboBox5.Items.Add(tb66.Text)
        If tb67.Enabled = True Then ComboBox5.Items.Add(tb67.Text)
        If tb68.Enabled = True Then ComboBox5.Items.Add(tb68.Text)
        If tb69.Enabled = True Then ComboBox5.Items.Add(tb69.Text)
        If tb70.Enabled = True Then ComboBox5.Items.Add(tb70.Text)

        If tb91.Enabled = True Then ComboBox7.Items.Add(tb91.Text)
        If tb92.Enabled = True Then ComboBox7.Items.Add(tb92.Text)
        If tb93.Enabled = True Then ComboBox7.Items.Add(tb93.Text)
        If tb94.Enabled = True Then ComboBox7.Items.Add(tb94.Text)
        If tb95.Enabled = True Then ComboBox7.Items.Add(tb95.Text)
        If tb96.Enabled = True Then ComboBox7.Items.Add(tb96.Text)
        If tb97.Enabled = True Then ComboBox7.Items.Add(tb97.Text)
        If tb98.Enabled = True Then ComboBox7.Items.Add(tb98.Text)
        If tb99.Enabled = True Then ComboBox7.Items.Add(tb99.Text)
        If tb100.Enabled = True Then ComboBox7.Items.Add(tb100.Text)

        If tb121.Enabled = True Then ComboBox9.Items.Add(tb121.Text)
        If tb122.Enabled = True Then ComboBox9.Items.Add(tb122.Text)
        If tb123.Enabled = True Then ComboBox9.Items.Add(tb123.Text)
        If tb124.Enabled = True Then ComboBox9.Items.Add(tb124.Text)
        If tb125.Enabled = True Then ComboBox9.Items.Add(tb125.Text)
        If tb126.Enabled = True Then ComboBox9.Items.Add(tb126.Text)
        If tb127.Enabled = True Then ComboBox9.Items.Add(tb127.Text)
        If tb128.Enabled = True Then ComboBox9.Items.Add(tb128.Text)
        If tb129.Enabled = True Then ComboBox9.Items.Add(tb129.Text)
        If tb130.Enabled = True Then ComboBox9.Items.Add(tb130.Text)

        If tb1.Enabled = True Then ComboBox2.Items.Add(tb1.Text)
        If tb2.Enabled = True Then ComboBox2.Items.Add(tb2.Text)
        If tb3.Enabled = True Then ComboBox2.Items.Add(tb3.Text)
        If tb4.Enabled = True Then ComboBox2.Items.Add(tb4.Text)
        If tb5.Enabled = True Then ComboBox2.Items.Add(tb5.Text)
        If tb6.Enabled = True Then ComboBox2.Items.Add(tb6.Text)
        If tb7.Enabled = True Then ComboBox2.Items.Add(tb7.Text)
        If tb8.Enabled = True Then ComboBox2.Items.Add(tb8.Text)
        If tb9.Enabled = True Then ComboBox2.Items.Add(tb9.Text)
        If tb10.Enabled = True Then ComboBox2.Items.Add(tb10.Text)

        If tb31.Enabled = True Then ComboBox4.Items.Add(tb31.Text)
        If tb32.Enabled = True Then ComboBox4.Items.Add(tb32.Text)
        If tb33.Enabled = True Then ComboBox4.Items.Add(tb33.Text)
        If tb34.Enabled = True Then ComboBox4.Items.Add(tb34.Text)
        If tb35.Enabled = True Then ComboBox4.Items.Add(tb35.Text)
        If tb36.Enabled = True Then ComboBox4.Items.Add(tb36.Text)
        If tb37.Enabled = True Then ComboBox4.Items.Add(tb37.Text)
        If tb38.Enabled = True Then ComboBox4.Items.Add(tb38.Text)
        If tb39.Enabled = True Then ComboBox4.Items.Add(tb39.Text)
        If tb40.Enabled = True Then ComboBox4.Items.Add(tb40.Text)

        If tb61.Enabled = True Then ComboBox6.Items.Add(tb61.Text)
        If tb62.Enabled = True Then ComboBox6.Items.Add(tb62.Text)
        If tb63.Enabled = True Then ComboBox6.Items.Add(tb63.Text)
        If tb64.Enabled = True Then ComboBox6.Items.Add(tb64.Text)
        If tb65.Enabled = True Then ComboBox6.Items.Add(tb65.Text)
        If tb66.Enabled = True Then ComboBox6.Items.Add(tb66.Text)
        If tb67.Enabled = True Then ComboBox6.Items.Add(tb67.Text)
        If tb68.Enabled = True Then ComboBox6.Items.Add(tb68.Text)
        If tb69.Enabled = True Then ComboBox6.Items.Add(tb69.Text)
        If tb70.Enabled = True Then ComboBox6.Items.Add(tb70.Text)

        If tb91.Enabled = True Then ComboBox8.Items.Add(tb91.Text)
        If tb92.Enabled = True Then ComboBox8.Items.Add(tb92.Text)
        If tb93.Enabled = True Then ComboBox8.Items.Add(tb93.Text)
        If tb94.Enabled = True Then ComboBox8.Items.Add(tb94.Text)
        If tb95.Enabled = True Then ComboBox8.Items.Add(tb95.Text)
        If tb96.Enabled = True Then ComboBox8.Items.Add(tb96.Text)
        If tb97.Enabled = True Then ComboBox8.Items.Add(tb97.Text)
        If tb98.Enabled = True Then ComboBox8.Items.Add(tb98.Text)
        If tb99.Enabled = True Then ComboBox8.Items.Add(tb99.Text)
        If tb100.Enabled = True Then ComboBox8.Items.Add(tb100.Text)

        If tb121.Enabled = True Then ComboBox10.Items.Add(tb121.Text)
        If tb122.Enabled = True Then ComboBox10.Items.Add(tb122.Text)
        If tb123.Enabled = True Then ComboBox10.Items.Add(tb123.Text)
        If tb124.Enabled = True Then ComboBox10.Items.Add(tb124.Text)
        If tb125.Enabled = True Then ComboBox10.Items.Add(tb125.Text)
        If tb126.Enabled = True Then ComboBox10.Items.Add(tb126.Text)
        If tb127.Enabled = True Then ComboBox10.Items.Add(tb127.Text)
        If tb128.Enabled = True Then ComboBox10.Items.Add(tb128.Text)
        If tb129.Enabled = True Then ComboBox10.Items.Add(tb129.Text)
        If tb130.Enabled = True Then ComboBox10.Items.Add(tb130.Text)
        'On met a jour le dessin
        pct_Reseau.Refresh()
    End Sub
    'Dessiner les lignes
    Private Sub dessinerLigne(ByVal L As Ligne, ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim i As Integer

        Dim skyBluePen As New Pen(Brushes.DeepSkyBlue)
        skyBluePen.Width = 2.0F

        Dim OrangeRedPen As New Pen(Brushes.OrangeRed)
        OrangeRedPen.Width = 2.0F

        Dim LimeGreenPen As New Pen(Brushes.LimeGreen)
        LimeGreenPen.Width = 2.0F

        Dim VioletPen As New Pen(Brushes.Violet)
        VioletPen.Width = 2.0F

        Dim MidnightBluePen As New Pen(Brushes.MidnightBlue)
        MidnightBluePen.Width = 2.0F

        Dim rect As Rectangle
        For i = 0 To L.nbStations - 1
            rect.Height = 3
            rect.Width = 3
            rect.X = L.station(i).position.x * 10
            rect.Y = L.station(i).position.y * 10
            e.Graphics.DrawEllipse(Pens.Black, rect)
            e.Graphics.DrawString(L.station(i).nom, SystemFonts.StatusFont, Brushes.Black, New Point(L.station(i).position.x * 10, L.station(i).position.y * 10 - 10))
        Next
        For i = 0 To r(0).nbStations - 2
            e.Graphics.DrawLine(skyBluePen, New Point(r(0).station(i).position.x * 10, r(0).station(i).position.y * 10), New Point(r(0).station(i + 1).position.x * 10, r(0).station(i + 1).position.y * 10))
        Next
        For i = 0 To r(1).nbStations - 2
            e.Graphics.DrawLine(OrangeRedPen, New Point(r(1).station(i).position.x * 10, r(1).station(i).position.y * 10), New Point(r(1).station(i + 1).position.x * 10, r(1).station(i + 1).position.y * 10))
        Next
        For i = 0 To r(2).nbStations - 2
            e.Graphics.DrawLine(LimeGreenPen, New Point(r(2).station(i).position.x * 10, r(2).station(i).position.y * 10), New Point(r(2).station(i + 1).position.x * 10, r(2).station(i + 1).position.y * 10))
        Next
        For i = 0 To r(3).nbStations - 2
            e.Graphics.DrawLine(VioletPen, New Point(r(3).station(i).position.x * 10, r(3).station(i).position.y * 10), New Point(r(3).station(i + 1).position.x * 10, r(3).station(i + 1).position.y * 10))
        Next
        For i = 0 To r(4).nbStations - 2
            e.Graphics.DrawLine(MidnightBluePen, New Point(r(4).station(i).position.x * 10, r(4).station(i).position.y * 10), New Point(r(4).station(i + 1).position.x * 10, r(4).station(i + 1).position.y * 10))
        Next
    End Sub
    'Application pour gerer le reseau, il prend les valeurs de la partie traitement et les stockent
    Public Sub Reseau(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pct_Reseau.Paint

        nbLignes = Label1.Text

        r(0).nom = tb151.Text
        r(1).nom = tb152.Text
        r(2).nom = tb153.Text
        r(3).nom = tb154.Text
        r(4).nom = tb155.Text

        ReDim r(0).station(10)
        ReDim r(1).station(10)
        ReDim r(2).station(10)
        ReDim r(3).station(10)
        ReDim r(4).station(10)

        r(0).nbStations = Label2.Text
        r(1).nbStations = Label3.Text
        r(2).nbStations = Label4.Text
        r(3).nbStations = Label5.Text
        r(4).nbStations = Label6.Text

        r(0).numeroligne = 1
        r(1).numeroligne = 2
        r(2).numeroligne = 3
        r(3).numeroligne = 4
        r(4).numeroligne = 5

        If tb1.Enabled = True Then r(0).station(0).nom = tb1.Text : r(0).station(0).position.x = tb11.Text : r(0).station(0).position.y = tb12.Text
        If tb2.Enabled = True Then r(0).station(1).nom = tb2.Text : r(0).station(1).position.x = tb13.Text : r(0).station(1).position.y = tb14.Text
        If tb3.Enabled = True Then r(0).station(2).nom = tb3.Text : r(0).station(2).position.x = tb15.Text : r(0).station(2).position.y = tb16.Text
        If tb4.Enabled = True Then r(0).station(3).nom = tb4.Text : r(0).station(3).position.x = tb17.Text : r(0).station(3).position.y = tb18.Text
        If tb5.Enabled = True Then r(0).station(4).nom = tb5.Text : r(0).station(4).position.x = tb19.Text : r(0).station(4).position.y = tb20.Text
        If tb6.Enabled = True Then r(0).station(5).nom = tb6.Text : r(0).station(5).position.x = tb21.Text : r(0).station(5).position.y = tb22.Text
        If tb7.Enabled = True Then r(0).station(6).nom = tb7.Text : r(0).station(6).position.x = tb23.Text : r(0).station(6).position.y = tb24.Text
        If tb8.Enabled = True Then r(0).station(7).nom = tb8.Text : r(0).station(7).position.x = tb25.Text : r(0).station(7).position.y = tb26.Text
        If tb9.Enabled = True Then r(0).station(8).nom = tb9.Text : r(0).station(8).position.x = tb27.Text : r(0).station(8).position.y = tb28.Text
        If tb10.Enabled = True Then r(0).station(9).nom = tb10.Text : r(0).station(9).position.x = tb29.Text : r(0).station(9).position.y = tb30.Text

        If tb31.Enabled = True Then r(1).station(0).nom = tb31.Text : r(1).station(0).position.x = tb41.Text : r(1).station(0).position.y = tb42.Text
        If tb32.Enabled = True Then r(1).station(1).nom = tb32.Text : r(1).station(1).position.x = tb43.Text : r(1).station(1).position.y = tb44.Text
        If tb33.Enabled = True Then r(1).station(2).nom = tb33.Text : r(1).station(2).position.x = tb45.Text : r(1).station(2).position.y = tb46.Text
        If tb34.Enabled = True Then r(1).station(3).nom = tb34.Text : r(1).station(3).position.x = tb47.Text : r(1).station(3).position.y = tb48.Text
        If tb35.Enabled = True Then r(1).station(4).nom = tb35.Text : r(1).station(4).position.x = tb49.Text : r(1).station(4).position.y = tb50.Text
        If tb36.Enabled = True Then r(1).station(5).nom = tb36.Text : r(1).station(5).position.x = tb51.Text : r(1).station(5).position.y = tb52.Text
        If tb37.Enabled = True Then r(1).station(6).nom = tb37.Text : r(1).station(6).position.x = tb53.Text : r(1).station(6).position.y = tb54.Text
        If tb38.Enabled = True Then r(1).station(7).nom = tb38.Text : r(1).station(7).position.x = tb55.Text : r(1).station(7).position.y = tb56.Text
        If tb39.Enabled = True Then r(1).station(8).nom = tb39.Text : r(1).station(8).position.x = tb57.Text : r(1).station(8).position.y = tb58.Text
        If tb40.Enabled = True Then r(1).station(9).nom = tb40.Text : r(1).station(9).position.x = tb59.Text : r(1).station(9).position.y = tb60.Text

        If tb61.Enabled = True Then r(2).station(0).nom = tb61.Text : r(2).station(0).position.x = tb71.Text : r(2).station(0).position.y = tb72.Text
        If tb62.Enabled = True Then r(2).station(1).nom = tb62.Text : r(2).station(1).position.x = tb73.Text : r(2).station(1).position.y = tb74.Text
        If tb63.Enabled = True Then r(2).station(2).nom = tb63.Text : r(2).station(2).position.x = tb75.Text : r(2).station(2).position.y = tb76.Text
        If tb64.Enabled = True Then r(2).station(3).nom = tb64.Text : r(2).station(3).position.x = tb77.Text : r(2).station(3).position.y = tb78.Text
        If tb65.Enabled = True Then r(2).station(4).nom = tb65.Text : r(2).station(4).position.x = tb79.Text : r(2).station(4).position.y = tb80.Text
        If tb66.Enabled = True Then r(2).station(5).nom = tb66.Text : r(2).station(5).position.x = tb81.Text : r(2).station(5).position.y = tb82.Text
        If tb67.Enabled = True Then r(2).station(6).nom = tb67.Text : r(2).station(6).position.x = tb83.Text : r(2).station(6).position.y = tb84.Text
        If tb68.Enabled = True Then r(2).station(7).nom = tb68.Text : r(2).station(7).position.x = tb85.Text : r(2).station(7).position.y = tb86.Text
        If tb69.Enabled = True Then r(2).station(8).nom = tb69.Text : r(2).station(8).position.x = tb87.Text : r(2).station(8).position.y = tb88.Text
        If tb70.Enabled = True Then r(2).station(9).nom = tb70.Text : r(2).station(9).position.x = tb89.Text : r(2).station(9).position.y = tb90.Text

        If tb91.Enabled = True Then r(3).station(0).nom = tb91.Text : r(3).station(0).position.x = tb101.Text : r(3).station(0).position.y = tb102.Text
        If tb92.Enabled = True Then r(3).station(1).nom = tb92.Text : r(3).station(1).position.x = tb103.Text : r(3).station(1).position.y = tb104.Text
        If tb93.Enabled = True Then r(3).station(2).nom = tb93.Text : r(3).station(2).position.x = tb105.Text : r(3).station(2).position.y = tb106.Text
        If tb94.Enabled = True Then r(3).station(3).nom = tb94.Text : r(3).station(3).position.x = tb107.Text : r(3).station(3).position.y = tb108.Text
        If tb95.Enabled = True Then r(3).station(4).nom = tb95.Text : r(3).station(4).position.x = tb109.Text : r(3).station(4).position.y = tb110.Text
        If tb96.Enabled = True Then r(3).station(5).nom = tb96.Text : r(3).station(5).position.x = tb111.Text : r(3).station(5).position.y = tb112.Text
        If tb97.Enabled = True Then r(3).station(6).nom = tb97.Text : r(3).station(6).position.x = tb113.Text : r(3).station(6).position.y = tb114.Text
        If tb98.Enabled = True Then r(3).station(7).nom = tb98.Text : r(3).station(7).position.x = tb115.Text : r(3).station(7).position.y = tb116.Text
        If tb99.Enabled = True Then r(3).station(8).nom = tb99.Text : r(3).station(8).position.x = tb117.Text : r(3).station(8).position.y = tb118.Text
        If tb100.Enabled = True Then r(3).station(9).nom = tb100.Text : r(3).station(9).position.x = tb119.Text : r(3).station(9).position.y = tb120.Text

        If tb121.Enabled = True Then r(4).station(0).nom = tb121.Text : r(4).station(0).position.x = tb131.Text : r(4).station(0).position.y = tb132.Text
        If tb122.Enabled = True Then r(4).station(1).nom = tb122.Text : r(4).station(1).position.x = tb133.Text : r(4).station(1).position.y = tb134.Text
        If tb123.Enabled = True Then r(4).station(2).nom = tb123.Text : r(4).station(2).position.x = tb135.Text : r(4).station(2).position.y = tb136.Text
        If tb124.Enabled = True Then r(4).station(3).nom = tb124.Text : r(4).station(3).position.x = tb137.Text : r(4).station(3).position.y = tb138.Text
        If tb125.Enabled = True Then r(4).station(4).nom = tb125.Text : r(4).station(4).position.x = tb139.Text : r(4).station(4).position.y = tb140.Text
        If tb126.Enabled = True Then r(4).station(5).nom = tb126.Text : r(4).station(5).position.x = tb141.Text : r(4).station(5).position.y = tb142.Text
        If tb127.Enabled = True Then r(4).station(6).nom = tb127.Text : r(4).station(6).position.x = tb143.Text : r(4).station(6).position.y = tb144.Text
        If tb128.Enabled = True Then r(4).station(7).nom = tb128.Text : r(4).station(7).position.x = tb145.Text : r(4).station(7).position.y = tb146.Text
        If tb129.Enabled = True Then r(4).station(8).nom = tb129.Text : r(4).station(8).position.x = tb147.Text : r(4).station(8).position.y = tb148.Text
        If tb130.Enabled = True Then r(4).station(9).nom = tb130.Text : r(4).station(9).position.x = tb149.Text : r(4).station(9).position.y = tb150.Text

        'On dessine le reseau
        
        dessinerLigne(r(0), sender, e)
        dessinerLigne(r(1), sender, e)
        dessinerLigne(r(2), sender, e)
        dessinerLigne(r(3), sender, e)
        dessinerLigne(r(4), sender, e)

    End Sub
    'Repasser a la partie "traitement"
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Panel2.Visible = False
        Panel1.Visible = True
    End Sub
    'Calcul de distance pour la ligne 1
    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Then Beep() : MsgBox("Selectionnez une station de depart et une station d'arrivee avant de proceder au calcul!") : Label7.Text = 0 
        Dim a As Integer
        Dim b As Integer
        Dim distance As Double
        distance = 0
        For i = 0 To r(0).nbStations
            If r(0).station(i).nom = ComboBox1.Text Then a = i
            If r(0).station(i).nom = ComboBox2.Text Then b = i
        Next
        If a = b Then Label7.Text = 0
        If a < b Then
            For j = a To b - 1
                ListBox1.Items.Add(r(0).station(j).nom)
                distance = distance + ((r(0).station(j + 1).position.y - r(0).station(j).position.y) ^ 2 + (r(0).station(j + 1).position.x - r(0).station(j).position.x) ^ 2) ^ (1 / 2)
            Next
            ListBox1.Items.Add(r(0).station(b).nom)
        End If
        If a > b Then
            For j = b To a - 1
                ListBox1.Items.Add(r(0).station(j).nom)
                distance = distance + ((r(0).station(j + 1).position.y - r(0).station(j).position.y) ^ 2 + (r(0).station(j + 1).position.x - r(0).station(j).position.x) ^ 2) ^ (1 / 2)
            Next
            ListBox1.Items.Add(r(0).station(a).nom)
        End If
        Label7.Text = Math.Round(distance, 2)
        Dim DistanceActuelle As Double
        Dim DistanceTotale As Double
        DistanceActuelle = Label19.Text
        DistanceTotale = DistanceActuelle + distance
        Label19.Text = Math.Round(DistanceTotale, 2)
        For k = 0 To r(1).nbStations
            If r(0).station(a).nom = r(1).station(k).nom Then ComboBox4.Text = r(0).station(a).nom
        Next
        For l = 0 To r(1).nbStations
            If r(0).station(b).nom = r(1).station(l).nom Then ComboBox3.Text = r(0).station(b).nom
        Next
        For k = 0 To r(2).nbStations
            If r(0).station(a).nom = r(2).station(k).nom Then ComboBox6.Text = r(0).station(a).nom
        Next
        For l = 0 To r(2).nbStations
            If r(0).station(b).nom = r(2).station(l).nom Then ComboBox5.Text = r(0).station(b).nom
        Next
        For k = 0 To r(3).nbStations
            If r(0).station(a).nom = r(3).station(k).nom Then ComboBox8.Text = r(0).station(a).nom
        Next
        For l = 0 To r(3).nbStations
            If r(0).station(b).nom = r(3).station(l).nom Then ComboBox7.Text = r(0).station(b).nom
        Next
        For k = 0 To r(4).nbStations
            If r(0).station(a).nom = r(4).station(k).nom Then ComboBox10.Text = r(0).station(a).nom
        Next
        For l = 0 To r(4).nbStations
            If r(0).station(b).nom = r(4).station(l).nom Then ComboBox9.Text = r(0).station(b).nom
        Next
    End Sub
    'Calcul de distance pour la ligne 2
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If ComboBox3.Text = "" Or ComboBox4.Text = "" Then Beep() : MsgBox("Selectionnez une station de départ et une station d'arrivée avant de procéder au calcul!") : Label8.Text = 0
        Dim a As Integer
        Dim b As Integer
        Dim distance As Double
        distance = 0
        For i = 0 To r(1).nbStations
            If r(1).station(i).nom = ComboBox3.Text Then a = i
            If r(1).station(i).nom = ComboBox4.Text Then b = i
        Next
        If a = b Then Label8.Text = 0
        If a < b Then
            For j = a To b - 1
                ListBox1.Items.Add(r(1).station(j).nom)
                distance = distance + ((r(1).station(j + 1).position.y - r(1).station(j).position.y) ^ 2 + (r(1).station(j + 1).position.x - r(1).station(j).position.x) ^ 2) ^ (1 / 2)
            Next
            ListBox1.Items.Add(r(1).station(b).nom)
        End If
        If a > b Then
            For j = b To a - 1
                ListBox1.Items.Add(r(1).station(j).nom)
                distance = distance + ((r(1).station(j + 1).position.y - r(1).station(j).position.y) ^ 2 + (r(1).station(j + 1).position.x - r(1).station(j).position.x) ^ 2) ^ (1 / 2)
            Next
            ListBox1.Items.Add(r(1).station(a).nom)
        End If
        Label8.Text = Math.Round(distance, 2)
        Dim DistanceActuelle As Double
        Dim DistanceTotale As Double
        DistanceActuelle = Label19.Text
        DistanceTotale = DistanceActuelle + distance
        Label19.Text = Math.Round(DistanceTotale, 2)
        For k = 0 To r(0).nbStations
            If r(1).station(a).nom = r(0).station(k).nom Then ComboBox2.Text = r(1).station(a).nom
        Next
        For l = 0 To r(0).nbStations
            If r(1).station(b).nom = r(0).station(l).nom Then ComboBox1.Text = r(1).station(b).nom
        Next
        For k = 0 To r(2).nbStations
            If r(1).station(a).nom = r(2).station(k).nom Then ComboBox6.Text = r(1).station(a).nom
        Next
        For l = 0 To r(2).nbStations
            If r(1).station(b).nom = r(2).station(l).nom Then ComboBox5.Text = r(1).station(b).nom
        Next
        For k = 0 To r(3).nbStations
            If r(1).station(a).nom = r(3).station(k).nom Then ComboBox8.Text = r(1).station(a).nom
        Next
        For l = 0 To r(3).nbStations
            If r(1).station(b).nom = r(3).station(l).nom Then ComboBox7.Text = r(1).station(b).nom
        Next
        For k = 0 To r(4).nbStations
            If r(1).station(a).nom = r(4).station(k).nom Then ComboBox10.Text = r(1).station(a).nom
        Next
        For l = 0 To r(4).nbStations
            If r(1).station(b).nom = r(4).station(l).nom Then ComboBox9.Text = r(1).station(b).nom
        Next
    End Sub
    'Calcul de distance pour la ligne 3
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If ComboBox5.Text = "" Or ComboBox6.Text = "" Then Beep() : MsgBox("Selectionnez une station de depart et une station d'arrivee avant de proceder au calcul!") : Label9.Text = 0
        Dim a As Integer
        Dim b As Integer
        Dim distance As Double
        distance = 0
        For i = 0 To r(2).nbStations
            If r(2).station(i).nom = ComboBox5.Text Then a = i
            If r(2).station(i).nom = ComboBox6.Text Then b = i
        Next
        If a = b Then Label9.Text = 0
        If a < b Then
            For j = a To b - 1
                ListBox1.Items.Add(r(2).station(j).nom)
                distance = distance + ((r(2).station(j + 1).position.y - r(2).station(j).position.y) ^ 2 + (r(2).station(j + 1).position.x - r(2).station(j).position.x) ^ 2) ^ (1 / 2)
            Next
            ListBox1.Items.Add(r(2).station(b).nom)
        End If
        If a > b Then
            For j = b To a - 1
                ListBox1.Items.Add(r(2).station(j).nom)
                distance = distance + ((r(2).station(j + 1).position.y - r(2).station(j).position.y) ^ 2 + (r(2).station(j + 1).position.x - r(2).station(j).position.x) ^ 2) ^ (1 / 2)
            Next
            ListBox1.Items.Add(r(2).station(a).nom)
        End If
        Label9.Text = Math.Round(distance, 2)
        Dim DistanceActuelle As Double
        Dim DistanceTotale As Double
        DistanceActuelle = Label19.Text
        DistanceTotale = DistanceActuelle + distance
        Label19.Text = Math.Round(DistanceTotale, 2)
        For k = 0 To r(0).nbStations
            If r(2).station(a).nom = r(0).station(k).nom Then ComboBox2.Text = r(2).station(a).nom
        Next
        For l = 0 To r(0).nbStations
            If r(2).station(b).nom = r(0).station(l).nom Then ComboBox1.Text = r(2).station(b).nom
        Next
        For k = 0 To r(1).nbStations
            If r(2).station(a).nom = r(1).station(k).nom Then ComboBox4.Text = r(2).station(a).nom
        Next
        For l = 0 To r(1).nbStations
            If r(2).station(b).nom = r(1).station(l).nom Then ComboBox3.Text = r(2).station(b).nom
        Next
        For k = 0 To r(3).nbStations
            If r(2).station(a).nom = r(3).station(k).nom Then ComboBox8.Text = r(2).station(a).nom
        Next
        For l = 0 To r(3).nbStations
            If r(2).station(b).nom = r(3).station(l).nom Then ComboBox7.Text = r(2).station(b).nom
        Next
        For k = 0 To r(4).nbStations
            If r(2).station(a).nom = r(4).station(k).nom Then ComboBox10.Text = r(2).station(a).nom
        Next
        For l = 0 To r(4).nbStations
            If r(2).station(b).nom = r(4).station(l).nom Then ComboBox9.Text = r(2).station(b).nom
        Next
        
    End Sub
    'Calcul de distance pour la ligne 4
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        If ComboBox7.Text = "" Or ComboBox8.Text = "" Then Beep() : MsgBox("Selectionnez une station de depart et une station d'arrivee avant de proceder au calcul!") : Label10.Text = 0
        Dim a As Integer
        Dim b As Integer
        Dim distance As Double
        distance = 0
        For i = 0 To r(3).nbStations
            If r(3).station(i).nom = ComboBox7.Text Then a = i
            If r(3).station(i).nom = ComboBox8.Text Then b = i
        Next
        If a = b Then Label10.Text = 0
        If a < b Then
            For j = a To b - 1
                ListBox1.Items.Add(r(3).station(j).nom)
                distance = distance + ((r(3).station(j + 1).position.y - r(3).station(j).position.y) ^ 2 + (r(3).station(j + 1).position.x - r(3).station(j).position.x) ^ 2) ^ (1 / 2)
            Next
            ListBox1.Items.Add(r(3).station(b).nom)
        End If
        If a > b Then
            For j = b To a - 1
                ListBox1.Items.Add(r(3).station(j).nom)
                distance = distance + ((r(3).station(j + 1).position.y - r(3).station(j).position.y) ^ 2 + (r(3).station(j + 1).position.x - r(3).station(j).position.x) ^ 2) ^ (1 / 2)
            Next
            ListBox1.Items.Add(r(3).station(a).nom)
        End If
        Label10.Text = Math.Round(distance, 2)
        Dim DistanceActuelle As Double
        Dim DistanceTotale As Double
        DistanceActuelle = Label19.Text
        DistanceTotale = DistanceActuelle + distance
        Label19.Text = Math.Round(DistanceTotale, 2)
        For k = 0 To r(0).nbStations
            If r(3).station(a).nom = r(0).station(k).nom Then ComboBox2.Text = r(3).station(a).nom
        Next
        For l = 0 To r(0).nbStations
            If r(3).station(b).nom = r(0).station(l).nom Then ComboBox1.Text = r(3).station(b).nom
        Next
        For k = 0 To r(1).nbStations
            If r(3).station(a).nom = r(1).station(k).nom Then ComboBox4.Text = r(3).station(a).nom
        Next
        For l = 0 To r(1).nbStations
            If r(3).station(b).nom = r(1).station(l).nom Then ComboBox3.Text = r(3).station(b).nom
        Next
        For k = 0 To r(2).nbStations
            If r(3).station(a).nom = r(2).station(k).nom Then ComboBox6.Text = r(3).station(a).nom
        Next
        For l = 0 To r(2).nbStations
            If r(3).station(b).nom = r(2).station(l).nom Then ComboBox5.Text = r(3).station(b).nom
        Next
        For k = 0 To r(4).nbStations
            If r(3).station(a).nom = r(4).station(k).nom Then ComboBox10.Text = r(3).station(a).nom
        Next
        For l = 0 To r(4).nbStations
            If r(3).station(b).nom = r(4).station(l).nom Then ComboBox9.Text = r(3).station(b).nom
        Next
    End Sub
    'Calcul de distance pour la ligne 5
    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        If ComboBox9.Text = "" Or ComboBox10.Text = "" Then Beep() : MsgBox("Selectionnez une station de depart et une station d'arrivee avant de proceder au calcul!") : Label11.Text = 0
        Dim a As Integer
        Dim b As Integer
        Dim distance As Double
        distance = 0
        For i = 0 To r(4).nbStations
            If r(4).station(i).nom = ComboBox9.Text Then a = i
            If r(4).station(i).nom = ComboBox10.Text Then b = i
        Next
        If a = b Then Label11.Text = 0
        If a < b Then
            For j = a To b - 1
                ListBox1.Items.Add(r(4).station(j).nom)
                distance = distance + ((r(4).station(j + 1).position.y - r(4).station(j).position.y) ^ 2 + (r(4).station(j + 1).position.x - r(4).station(j).position.x) ^ 2) ^ (1 / 2)
            Next
            ListBox1.Items.Add(r(4).station(b).nom)
        End If
        If a > b Then
            For j = b To a - 1
                ListBox1.Items.Add(r(4).station(j).nom)
                distance = distance + ((r(4).station(j + 1).position.y - r(4).station(j).position.y) ^ 2 + (r(4).station(j + 1).position.x - r(4).station(j).position.x) ^ 2) ^ (1 / 2)
            Next
            ListBox1.Items.Add(r(4).station(a).nom)
        End If
        Label11.Text = Math.Round(distance, 2)
        Dim DistanceActuelle As Double
        Dim DistanceTotale As Double
        DistanceActuelle = Label19.Text
        DistanceTotale = DistanceActuelle + distance
        Label19.Text = Math.Round(DistanceTotale, 2)
        For k = 0 To r(0).nbStations
            If r(4).station(a).nom = r(0).station(k).nom Then ComboBox2.Text = r(4).station(a).nom
        Next
        For l = 0 To r(0).nbStations
            If r(4).station(b).nom = r(0).station(l).nom Then ComboBox1.Text = r(4).station(b).nom
        Next
        For k = 0 To r(1).nbStations
            If r(4).station(a).nom = r(1).station(k).nom Then ComboBox4.Text = r(4).station(a).nom
        Next
        For l = 0 To r(1).nbStations
            If r(4).station(b).nom = r(1).station(l).nom Then ComboBox3.Text = r(4).station(b).nom
        Next
        For k = 0 To r(2).nbStations
            If r(4).station(a).nom = r(2).station(k).nom Then ComboBox6.Text = r(4).station(a).nom
        Next
        For l = 0 To r(2).nbStations
            If r(4).station(b).nom = r(2).station(l).nom Then ComboBox5.Text = r(4).station(b).nom
        Next
        For k = 0 To r(4).nbStations
            If r(4).station(a).nom = r(3).station(k).nom Then ComboBox8.Text = r(4).station(a).nom
        Next
        For l = 0 To r(4).nbStations
            If r(4).station(b).nom = r(3).station(l).nom Then ComboBox7.Text = r(4).station(b).nom
        Next
    End Sub
    'Recommencer le calcul
    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        ComboBox1.Text = "" : ComboBox2.Text = "" : ComboBox3.Text = "" : ComboBox4.Text = "" : ComboBox5.Text = "" : ComboBox6.Text = "" : ComboBox7.Text = "" : ComboBox8.Text = "" : ComboBox9.Text = "" : ComboBox10.Text = ""
        Label7.Text = 0 : Label8.Text = 0 : Label9.Text = 0 : Label10.Text = 0 : Label11.Text = 0 : Label19.Text = 0
    End Sub


End Class
