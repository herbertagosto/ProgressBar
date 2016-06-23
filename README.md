# ProgressBar
Simplify progress bar implementation on winforms

![Sample](https://github.com/herbertagosto/ProgressBar/blob/master/Resources/sample.png)


## Getting Started

```
private void button1_Click(object sender, EventArgs e)
{
	// start
	ProgressBar.UI.Start(this);
	for (int i = 0; i < 2; i++)
	{
		// long process..
		System.Threading.Thread.Sleep(1000);
	}
	// stop/exit
	ProgressBar.UI.Stop();
}
```

```
# API:
ProgressBar.UI.Message = "Progress message";

// Set up speed in milliseconds
ProgressBar.UI.Interval = 100;

// Pause/play progress
ProgressBar.UI.Pause();
ProgressBar.UI.Play();

// Hide/show UI
ProgressBar.UI.Hide();
ProgressBar.UI.Show()
```


### Prerequisities

.NET Framework 4


### Installing

https://www.nuget.org/packages/ProgressBar/


## Built With

visual studio 2013


## License

see [LICENSE](https://github.com/herbertagosto/ProgressBar/blob/master/LICENSE) file
