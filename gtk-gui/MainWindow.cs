
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action openAction;
	
	private global::Gtk.Action Action;
	
	private global::Gtk.VBox vbox10;
	
	private global::Gtk.MenuBar menubar1;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.Frame frame1;
	
	private global::Gtk.Alignment GtkAlignment;
	
	private global::Gtk.VBox vbox4;
	
	private global::Gtk.FileChooserButton filechooser_data;
	
	private global::Gtk.Label GtkLabel2;
	
	private global::Gtk.Frame frame2;
	
	private global::Gtk.Alignment GtkAlignment1;
	
	private global::Gtk.VBox vbox9;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	
	private global::Gtk.TextView txt_inputtext;
	
	private global::Gtk.VBox vbox13;
	
	private global::Gtk.VBox vbox16;
	
	private global::Gtk.VBox vbox5;
	
	private global::Gtk.VBox vbox17;
	
	private global::Gtk.Label GtkLabel3;
	
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.VBox vbox6;
	
	private global::Gtk.Label label1;
	
	private global::Gtk.VBox vbox7;
	
	private global::Gtk.RadioButton rdb_substitution;
	
	private global::Gtk.RadioButton rdb_transposition;
	
	private global::Gtk.RadioButton rdb_vernam;
	
	private global::Gtk.VBox vbox8;
	
	private global::Gtk.RadioButton rdb_vigenere;
	
	private global::Gtk.HSeparator hseparator1;
	
	private global::Gtk.VBox vbox14;
	
	private global::Gtk.VBox vbox18;
	
	private global::Gtk.Label label6;
	
	private global::Gtk.Entry txt_inputkey;
	
	private global::Gtk.Label label7;
	
	private global::Gtk.FileChooserButton filechooser_keyfile;
	
	private global::Gtk.VBox vbox3;
	
	private global::Gtk.VBox vbox15;
	
	private global::Gtk.Label label8;
	
	private global::Gtk.VBox vbox21;
	
	private global::Gtk.Button btn_encrypt;
	
	private global::Gtk.Button btn_decrypt;
	
	private global::Gtk.Button btn_test;
	
	private global::Gtk.VBox vbox11;
	
	private global::Gtk.VBox vbox12;
	
	private global::Gtk.Label label2;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow1;
	
	private global::Gtk.TextView txt_log;
	
	private global::Gtk.Button txt_log_clear;
	
	private global::Gtk.ProgressBar progressbar4;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.openAction = new global::Gtk.Action ("openAction", null, null, "gtk-open");
		w1.Add (this.openAction, null);
		this.Action = new global::Gtk.Action ("Action", null, null, null);
		w1.Add (this.Action, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Securish");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(8));
		this.Resizable = false;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox10 = new global::Gtk.VBox ();
		this.vbox10.Name = "vbox10";
		this.vbox10.Spacing = 6;
		// Container child vbox10.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='Action' action='Action'/></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox10.Add (this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox10.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame1 = new global::Gtk.Frame ();
		this.frame1.Name = "frame1";
		this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.filechooser_data = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Select a File"), ((global::Gtk.FileChooserAction)(0)));
		this.filechooser_data.WidthRequest = 200;
		this.filechooser_data.Name = "filechooser_data";
		this.vbox4.Add (this.filechooser_data);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.filechooser_data]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		this.GtkAlignment.Add (this.vbox4);
		this.frame1.Add (this.GtkAlignment);
		this.GtkLabel2 = new global::Gtk.Label ();
		this.GtkLabel2.Name = "GtkLabel2";
		this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Import File</b>");
		this.GtkLabel2.UseMarkup = true;
		this.frame1.LabelWidget = this.GtkLabel2;
		this.vbox1.Add (this.frame1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame1]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame2 = new global::Gtk.Frame ();
		this.frame2.Name = "frame2";
		this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame2.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		// Container child GtkAlignment1.Gtk.Container+ContainerChild
		this.vbox9 = new global::Gtk.VBox ();
		this.vbox9.Name = "vbox9";
		this.vbox9.Spacing = 6;
		// Container child vbox9.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.txt_inputtext = new global::Gtk.TextView ();
		this.txt_inputtext.HeightRequest = 250;
		this.txt_inputtext.CanFocus = true;
		this.txt_inputtext.Name = "txt_inputtext";
		this.GtkScrolledWindow.Add (this.txt_inputtext);
		this.vbox9.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.GtkScrolledWindow]));
		w8.Position = 0;
		// Container child vbox9.Gtk.Box+BoxChild
		this.vbox13 = new global::Gtk.VBox ();
		this.vbox13.Name = "vbox13";
		this.vbox13.Spacing = 6;
		// Container child vbox13.Gtk.Box+BoxChild
		this.vbox16 = new global::Gtk.VBox ();
		this.vbox16.Name = "vbox16";
		this.vbox16.Spacing = 6;
		// Container child vbox16.Gtk.Box+BoxChild
		this.vbox5 = new global::Gtk.VBox ();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		this.vbox16.Add (this.vbox5);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox16 [this.vbox5]));
		w9.Position = 0;
		this.vbox13.Add (this.vbox16);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox13 [this.vbox16]));
		w10.Position = 0;
		// Container child vbox13.Gtk.Box+BoxChild
		this.vbox17 = new global::Gtk.VBox ();
		this.vbox17.Name = "vbox17";
		this.vbox17.Spacing = 6;
		this.vbox13.Add (this.vbox17);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox13 [this.vbox17]));
		w11.Position = 1;
		this.vbox9.Add (this.vbox13);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.vbox13]));
		w12.Position = 1;
		this.GtkAlignment1.Add (this.vbox9);
		this.frame2.Add (this.GtkAlignment1);
		this.GtkLabel3 = new global::Gtk.Label ();
		this.GtkLabel3.Name = "GtkLabel3";
		this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Import Text</b>");
		this.GtkLabel3.UseMarkup = true;
		this.frame2.LabelWidget = this.GtkLabel3;
		this.vbox1.Add (this.frame2);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame2]));
		w15.Position = 1;
		this.hbox1.Add (this.vbox1);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox1]));
		w16.Position = 0;
		w16.Expand = false;
		w16.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.vbox6 = new global::Gtk.VBox ();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.WidthRequest = 200;
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Choose Cryptogtaphy Technique");
		this.vbox6.Add (this.label1);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.label1]));
		w17.Position = 0;
		w17.Expand = false;
		w17.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.vbox7 = new global::Gtk.VBox ();
		this.vbox7.Name = "vbox7";
		this.vbox7.Spacing = 6;
		// Container child vbox7.Gtk.Box+BoxChild
		this.rdb_substitution = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Substitution"));
		this.rdb_substitution.CanFocus = true;
		this.rdb_substitution.Name = "rdb_substitution";
		this.rdb_substitution.DrawIndicator = true;
		this.rdb_substitution.UseUnderline = true;
		this.rdb_substitution.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.vbox7.Add (this.rdb_substitution);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.rdb_substitution]));
		w18.Position = 0;
		w18.Expand = false;
		w18.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.rdb_transposition = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Transposition"));
		this.rdb_transposition.CanFocus = true;
		this.rdb_transposition.Name = "rdb_transposition";
		this.rdb_transposition.DrawIndicator = true;
		this.rdb_transposition.UseUnderline = true;
		this.rdb_transposition.Group = this.rdb_substitution.Group;
		this.vbox7.Add (this.rdb_transposition);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.rdb_transposition]));
		w19.Position = 1;
		w19.Expand = false;
		w19.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.rdb_vernam = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Vernam"));
		this.rdb_vernam.CanFocus = true;
		this.rdb_vernam.Name = "rdb_vernam";
		this.rdb_vernam.DrawIndicator = true;
		this.rdb_vernam.UseUnderline = true;
		this.rdb_vernam.Group = this.rdb_substitution.Group;
		this.vbox7.Add (this.rdb_vernam);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.rdb_vernam]));
		w20.Position = 2;
		w20.Expand = false;
		w20.Fill = false;
		this.vbox6.Add (this.vbox7);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.vbox7]));
		w21.Position = 1;
		w21.Expand = false;
		w21.Fill = false;
		this.vbox2.Add (this.vbox6);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.vbox6]));
		w22.Position = 0;
		w22.Expand = false;
		w22.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.vbox8 = new global::Gtk.VBox ();
		this.vbox8.Name = "vbox8";
		this.vbox8.Spacing = 6;
		// Container child vbox8.Gtk.Box+BoxChild
		this.rdb_vigenere = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Vigenere"));
		this.rdb_vigenere.CanFocus = true;
		this.rdb_vigenere.Name = "rdb_vigenere";
		this.rdb_vigenere.DrawIndicator = true;
		this.rdb_vigenere.UseUnderline = true;
		this.rdb_vigenere.Group = this.rdb_substitution.Group;
		this.vbox8.Add (this.rdb_vigenere);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.rdb_vigenere]));
		w23.Position = 0;
		w23.Expand = false;
		w23.Fill = false;
		// Container child vbox8.Gtk.Box+BoxChild
		this.hseparator1 = new global::Gtk.HSeparator ();
		this.hseparator1.Name = "hseparator1";
		this.vbox8.Add (this.hseparator1);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.hseparator1]));
		w24.Position = 1;
		w24.Expand = false;
		w24.Fill = false;
		// Container child vbox8.Gtk.Box+BoxChild
		this.vbox14 = new global::Gtk.VBox ();
		this.vbox14.Name = "vbox14";
		this.vbox14.Spacing = 6;
		// Container child vbox14.Gtk.Box+BoxChild
		this.vbox18 = new global::Gtk.VBox ();
		this.vbox18.Name = "vbox18";
		this.vbox18.Spacing = 6;
		// Container child vbox18.Gtk.Box+BoxChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Provide Key:");
		this.vbox18.Add (this.label6);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox18 [this.label6]));
		w25.Position = 0;
		w25.Expand = false;
		w25.Fill = false;
		// Container child vbox18.Gtk.Box+BoxChild
		this.txt_inputkey = new global::Gtk.Entry ();
		this.txt_inputkey.CanFocus = true;
		this.txt_inputkey.Name = "txt_inputkey";
		this.txt_inputkey.IsEditable = true;
		this.txt_inputkey.InvisibleChar = '●';
		this.vbox18.Add (this.txt_inputkey);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox18 [this.txt_inputkey]));
		w26.Position = 1;
		w26.Expand = false;
		w26.Fill = false;
		this.vbox14.Add (this.vbox18);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox14 [this.vbox18]));
		w27.Position = 0;
		w27.Expand = false;
		w27.Fill = false;
		// Container child vbox14.Gtk.Box+BoxChild
		this.label7 = new global::Gtk.Label ();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Keyfile:");
		this.vbox14.Add (this.label7);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox14 [this.label7]));
		w28.Position = 1;
		w28.Expand = false;
		w28.Fill = false;
		// Container child vbox14.Gtk.Box+BoxChild
		this.filechooser_keyfile = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Select a File"), ((global::Gtk.FileChooserAction)(0)));
		this.filechooser_keyfile.Name = "filechooser_keyfile";
		this.vbox14.Add (this.filechooser_keyfile);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox14 [this.filechooser_keyfile]));
		w29.Position = 2;
		w29.Expand = false;
		w29.Fill = false;
		this.vbox8.Add (this.vbox14);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.vbox14]));
		w30.Position = 2;
		w30.Expand = false;
		w30.Fill = false;
		this.vbox2.Add (this.vbox8);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.vbox8]));
		w31.Position = 1;
		w31.Expand = false;
		w31.Fill = false;
		this.hbox1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
		w32.Position = 1;
		w32.Expand = false;
		w32.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.vbox15 = new global::Gtk.VBox ();
		this.vbox15.Name = "vbox15";
		this.vbox15.Spacing = 6;
		// Container child vbox15.Gtk.Box+BoxChild
		this.label8 = new global::Gtk.Label ();
		this.label8.WidthRequest = 200;
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Select Operation");
		this.vbox15.Add (this.label8);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox15 [this.label8]));
		w33.Position = 0;
		w33.Expand = false;
		w33.Fill = false;
		// Container child vbox15.Gtk.Box+BoxChild
		this.vbox21 = new global::Gtk.VBox ();
		this.vbox21.Name = "vbox21";
		this.vbox21.Spacing = 6;
		// Container child vbox21.Gtk.Box+BoxChild
		this.btn_encrypt = new global::Gtk.Button ();
		this.btn_encrypt.CanFocus = true;
		this.btn_encrypt.Name = "btn_encrypt";
		this.btn_encrypt.UseUnderline = true;
		this.btn_encrypt.Label = global::Mono.Unix.Catalog.GetString ("Encrypt");
		global::Gtk.Image w34 = new global::Gtk.Image ();
		w34.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "stock_lock", global::Gtk.IconSize.Menu);
		this.btn_encrypt.Image = w34;
		this.vbox21.Add (this.btn_encrypt);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox21 [this.btn_encrypt]));
		w35.Position = 0;
		w35.Expand = false;
		w35.Fill = false;
		// Container child vbox21.Gtk.Box+BoxChild
		this.btn_decrypt = new global::Gtk.Button ();
		this.btn_decrypt.CanFocus = true;
		this.btn_decrypt.Name = "btn_decrypt";
		this.btn_decrypt.UseUnderline = true;
		this.btn_decrypt.Label = global::Mono.Unix.Catalog.GetString ("Decrypt");
		global::Gtk.Image w36 = new global::Gtk.Image ();
		w36.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
		this.btn_decrypt.Image = w36;
		this.vbox21.Add (this.btn_decrypt);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox21 [this.btn_decrypt]));
		w37.Position = 1;
		w37.Expand = false;
		w37.Fill = false;
		// Container child vbox21.Gtk.Box+BoxChild
		this.btn_test = new global::Gtk.Button ();
		this.btn_test.CanFocus = true;
		this.btn_test.Name = "btn_test";
		this.btn_test.UseUnderline = true;
		this.btn_test.Label = global::Mono.Unix.Catalog.GetString ("Test");
		global::Gtk.Image w38 = new global::Gtk.Image ();
		w38.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-dialog-question", global::Gtk.IconSize.Menu);
		this.btn_test.Image = w38;
		this.vbox21.Add (this.btn_test);
		global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox21 [this.btn_test]));
		w39.Position = 2;
		w39.Expand = false;
		w39.Fill = false;
		this.vbox15.Add (this.vbox21);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox15 [this.vbox21]));
		w40.Position = 1;
		w40.Expand = false;
		w40.Fill = false;
		this.vbox3.Add (this.vbox15);
		global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox15]));
		w41.Position = 0;
		w41.Expand = false;
		w41.Fill = false;
		this.hbox1.Add (this.vbox3);
		global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox3]));
		w42.Position = 2;
		w42.Expand = false;
		w42.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox11 = new global::Gtk.VBox ();
		this.vbox11.Name = "vbox11";
		this.vbox11.Spacing = 6;
		// Container child vbox11.Gtk.Box+BoxChild
		this.vbox12 = new global::Gtk.VBox ();
		this.vbox12.Name = "vbox12";
		this.vbox12.Spacing = 6;
		// Container child vbox12.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.WidthRequest = 200;
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Log");
		this.vbox12.Add (this.label2);
		global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox12 [this.label2]));
		w43.Position = 0;
		w43.Expand = false;
		w43.Fill = false;
		// Container child vbox12.Gtk.Box+BoxChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.txt_log = new global::Gtk.TextView ();
		this.txt_log.WidthRequest = 160;
		this.txt_log.CanFocus = true;
		this.txt_log.Name = "txt_log";
		this.txt_log.Editable = false;
		this.GtkScrolledWindow1.Add (this.txt_log);
		this.vbox12.Add (this.GtkScrolledWindow1);
		global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vbox12 [this.GtkScrolledWindow1]));
		w45.Position = 1;
		this.vbox11.Add (this.vbox12);
		global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.vbox12]));
		w46.Position = 0;
		// Container child vbox11.Gtk.Box+BoxChild
		this.txt_log_clear = new global::Gtk.Button ();
		this.txt_log_clear.CanFocus = true;
		this.txt_log_clear.Name = "txt_log_clear";
		this.txt_log_clear.UseUnderline = true;
		this.txt_log_clear.Label = global::Mono.Unix.Catalog.GetString ("Clear Log");
		global::Gtk.Image w47 = new global::Gtk.Image ();
		w47.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-clear", global::Gtk.IconSize.Menu);
		this.txt_log_clear.Image = w47;
		this.vbox11.Add (this.txt_log_clear);
		global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.txt_log_clear]));
		w48.Position = 1;
		w48.Expand = false;
		w48.Fill = false;
		this.hbox1.Add (this.vbox11);
		global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox11]));
		w49.Position = 3;
		w49.Expand = false;
		w49.Fill = false;
		this.vbox10.Add (this.hbox1);
		global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.hbox1]));
		w50.Position = 1;
		w50.Expand = false;
		w50.Fill = false;
		// Container child vbox10.Gtk.Box+BoxChild
		this.progressbar4 = new global::Gtk.ProgressBar ();
		this.progressbar4.Name = "progressbar4";
		this.vbox10.Add (this.progressbar4);
		global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.progressbar4]));
		w51.Position = 2;
		w51.Expand = false;
		w51.Fill = false;
		this.Add (this.vbox10);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 848;
		this.DefaultHeight = 589;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btn_encrypt.Clicked += new global::System.EventHandler (this.OnBtnEncryptClicked);
		this.btn_decrypt.Clicked += new global::System.EventHandler (this.OnBtnDecryptClicked);
	}
}
