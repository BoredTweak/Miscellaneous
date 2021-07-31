import sys

class ProgressBar:
    def __init__(self):
        self.barLength = 10 # Modify this to change the length of the progress bar
        self.status = ""

    # update_progress() : Displays or updates a console progress bar
    ## Accepts a float between 0 and 1. Any int will be converted to a float.
    ## A value under 0 represents a 'halt'.
    ## A value at 1 or bigger represents 100%
    def update_progress(self, progress):      
        if isinstance(progress, int):
            progress = float(progress)
        if not isinstance(progress, float):
            progress = 0
            self.status = "error: progress var must be float\r\n"
        if progress < 0:
            progress = 0
            self.status = "Halt...\r\n"
        if progress >= 1:
            progress = 1
            self.status = "Done...\r\n"
        block = int(round(self.barLength*progress))
        text = "\rPercent: [{0}] {1}% {2}".format( "#"*block + "-"*(self.barLength-block), str(round(progress*100, 2)), self.status)
        sys.stdout.write(text)
        sys.stdout.flush()