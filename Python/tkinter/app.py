import tkinter

top = tkinter.Tk()
text_var = tkinter.StringVar(top)

def appendToButton():
    text_var.set(text_var.get() + 'a')
    
text_var.set('test')
text_label = tkinter.Label(top, textvariable=text_var).place(x=0,y=0)
append_button = tkinter.Button(top, width=20, command=appendToButton).place(x=0, y=40)
top.mainloop()
