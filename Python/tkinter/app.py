import tkinter

top = tkinter.Tk()
top.geometry("600x600")  # Set the initial size of the window
text_var = tkinter.StringVar(top)

def appendToButton():
    text_var.set(text_var.get() + 'a')

text_var.set('test')
text_label = tkinter.Label(top, textvariable=text_var).place(x=0, y=0)
append_button = tkinter.Button(top, width=20, command=appendToButton).place(x=0, y=40)

# Create a check button
check_var = tkinter.IntVar()
check_button = tkinter.Checkbutton(top, text="Check Button", variable=check_var).place(x=0, y=80)

# Create a radio button
radio_var = tkinter.StringVar()
radio_button1 = tkinter.Radiobutton(top, text="Radio Button 1", variable=radio_var, value="Option 1").place(x=0, y=100)
radio_button2 = tkinter.Radiobutton(top, text="Radio Button 2", variable=radio_var, value="Option 2").place(x=0, y=120)

# Create a listbox
listbox = tkinter.Listbox(top)
listbox.insert(1, "Item 1")
listbox.insert(2, "Item 2")
listbox.insert(3, "Item 3")
listbox.place(x=0, y=140)

# Create a text entry
entry = tkinter.Entry(top)
entry.place(x=0, y=180)

# Create a canvas
canvas = tkinter.Canvas(top, width=200, height=200, bg="white")
canvas.place(x=0, y=220)

top.mainloop()
