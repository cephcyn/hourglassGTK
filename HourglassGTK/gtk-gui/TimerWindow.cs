
// This file has been generated by the GUI designer. Do not modify.

public partial class TimerWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.Entry timerTitle;

	private global::Gtk.ProgressBar timerProgress;

	private global::Gtk.Entry timerEntry;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Button timerToggle;

	private global::Gtk.Button timerReset;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget TimerWindow
		this.Name = "TimerWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Timer");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.DefaultWidth = 300;
		this.DefaultHeight = 200;
		// Container child TimerWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.timerTitle = new global::Gtk.Entry();
		this.timerTitle.CanFocus = true;
		this.timerTitle.Name = "timerTitle";
		this.timerTitle.IsEditable = true;
		this.timerTitle.HasFrame = false;
		this.timerTitle.InvisibleChar = '•';
		this.timerTitle.Xalign = 0.5F;
		this.vbox1.Add(this.timerTitle);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.timerTitle]));
		w1.Position = 0;
		w1.Expand = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.timerProgress = new global::Gtk.ProgressBar();
		this.timerProgress.Name = "timerProgress";
		this.vbox1.Add(this.timerProgress);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.timerProgress]));
		w2.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.timerEntry = new global::Gtk.Entry();
		this.timerEntry.CanFocus = true;
		this.timerEntry.Name = "timerEntry";
		this.timerEntry.Text = global::Mono.Unix.Catalog.GetString("1 minute");
		this.timerEntry.IsEditable = true;
		this.timerEntry.HasFrame = false;
		this.timerEntry.InvisibleChar = '•';
		this.timerEntry.Xalign = 0.5F;
		this.vbox1.Add(this.timerEntry);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.timerEntry]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Homogeneous = true;
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.timerToggle = new global::Gtk.Button();
		this.timerToggle.Name = "timerToggle";
		this.timerToggle.UseUnderline = true;
		this.timerToggle.Label = global::Mono.Unix.Catalog.GetString("Pause/Resume");
		this.hbox2.Add(this.timerToggle);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.timerToggle]));
		w4.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.timerReset = new global::Gtk.Button();
		this.timerReset.Name = "timerReset";
		this.timerReset.UseUnderline = true;
		this.timerReset.Label = global::Mono.Unix.Catalog.GetString("Reset");
		this.hbox2.Add(this.timerReset);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.timerReset]));
		w5.Position = 1;
		this.vbox1.Add(this.hbox2);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
		w6.Position = 3;
		w6.Expand = false;
		w6.Fill = false;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}