# extends NewsAPI from newsapi.org
class NewsReader:
    def fetch(self):
        from newsapi import NewsApiClient
        with open('credentials.config', 'r') as config:
            credentials=config.read().replace('\n','')

        newsapi = NewsApiClient(api_key = credentials)
        top_headlines = newsapi.get_top_headlines(country='us')

        articles = top_headlines['articles']
           
        taglines = [ (o['title'], o['source']['name']) for o in articles]
        print taglines
        return taglines
    
from Tkinter import Tk, Label, Button
class NewsGui:
    def __init__(self, master):
        self.master = master
        master.title('News Reports')
        self.labels = []
        self.refresh_button = Button(self.master, text="Refresh", command=self.refresh)
        self.refresh_button.pack()
        self.close_button = Button(self.master, text="Close", command=master.quit)
        self.close_button.pack()
        self.refresh()
        
        
    def refresh(self):
        for label in self.labels:
            label.destroy()
        self.refresh_button.destroy()
        self.close_button.destroy()
        
        news = NewsReader()
        self.articles = news.fetch()
        for o in self.articles:
            self.label = Label(self.master, text=o[0] + " - " + o[1])
            self.label.pack()
            self.labels.append(self.label)
        
        self.refresh_button = Button(self.master, text="Refresh", command=self.refresh)
        self.refresh_button.pack()
        
        self.close_button = Button(self.master, text="Close", command=self.master.quit)
        self.close_button.pack()
            
root = Tk()
my_gui = NewsGui(root)
root.mainloop()    