# ProgressBar
Simplify progress bar implementation on winforms

![Sample](https://github.com/herbertagosto/ProgressBar/blob/master/Resources/sample.png)


## Getting Started

```
private void button1_Click(object sender, EventArgs e)
{
	ProgressBar.UI.Start(this);	// start progress bar
	// any process..
	ProgressBar.UI.Stop();		// stop progress bar
}
```

```
# API:
ProgressBar.UI.Message = "Progress message";
ProgressBar.UI.Interval = 100;		// set progress speed (milliseconds)
ProgressBar.UI.Pause();			// pause progress
ProgressBar.UI.Play();			// continue progress
ProgressBar.UI.Hide();			// Hides progress bar
ProgressBar.UI.Show()			// Show progress bar
```


### Prerequisities

.NET Framework 4


### Installing

https://www.nuget.org/packages/ProgressBar/


## Built With

visual studio 2013


## License

see [LICENSE](https://github.com/herbertagosto/ProgressBar/blob/master/LICENSE) file
