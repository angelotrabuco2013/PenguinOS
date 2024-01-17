import os, webbrowser
import tkinter as tk
from tkinter import messagebox, filedialog
from tkcode import CodeEditor


class PyEdit:
    def __init__(self, root):
        self.root = root
        self.root.title("Penguin OS PyBuilder")
        self.create_menu_bar()
        self.create_text_widgets()

    def create_menu_bar(self):
        self.menu_bar = tk.Menu(self.root)
        self.file_menu = tk.Menu(self.menu_bar, tearoff=0)
        self.file_menu.add_command(label="Open", command=self.open_file)
        self.file_menu.add_command(label="Save", command=self.save_file)
        self.file_menu.add_separator()
        self.file_menu.add_command(label="Exit", command=self.root.destroy)
        self.menu_bar.add_cascade(label="File", menu=self.file_menu)
        self.menu_bar.add_command(label="Terminal", command=self.open_terminal)
        self.about_menu = tk.Menu(self.menu_bar, tearoff=0)
        self.about_menu.add_command(label="About", command=self.show_about)
        self.about_menu.add_command(label="Source Code", command=self.open_source_code)
        self.menu_bar.add_cascade(label="About", menu=self.about_menu)
        self.root.config(menu=self.menu_bar)

    def create_text_widgets(self):
        self.linenumbers = tk.Text(
            self.root,
            width=3,
            padx=5,
            takefocus=0,
            border=0,
            background="#2f3136",
            foreground="white",
            font=("Bahnschrift", 12),
            state="disabled",
        )
        self.linenumbers.pack(side=tk.LEFT, fill=tk.Y)
        self.text_widget = CodeEditor(
            self.root,
            width=100,
            height=30,
            language="python",
            background="black",
            highlighter="dracula",
            font="Consolas",
            autofocus=True,
            blockcursor=False,
            insertofftime=0,
            padx=10,
            pady=10,
        )
        self.text_widget.pack(side=tk.LEFT, fill=tk.BOTH, expand=True)
        self.text_widget["yscrollcommand"], self.linenumbers["yscrollcommand"] = (
            self.scroll_y,
            self.scroll_y,
        )
        self.text_widget.bind("<Configure>", self.update_linenumbers)
        self.text_widget.bind("<Key>", self.schedule_update_linenumbers)
        self.text_widget.bind("<MouseWheel>", self.scroll)
        self.linenumbers.bind("<MouseWheel>", self.scroll)

    def scroll(self, event):
        delta_units = int(-1 * (event.delta / 120))
        self.linenumbers.yview_scroll(delta_units, "units")
        self.text_widget.yview_scroll(delta_units, "units")

    def scroll_y(self, *args):
        current_position = self.text_widget.yview()[0]
        self.text_widget.yview_moveto(args[0])
        self.linenumbers.yview_moveto(args[0])
        if current_position == 1.0 and float(args[0]) < 1.0:
            self.linenumbers.yview_scroll(1, "units")
            self.text_widget.yview_scroll(1, "units")

    def update_linenumbers(self, *args):
        self.linenumbers.config(state="normal")
        self.linenumbers.delete("1.0", tk.END)
        lines = self.text_widget.index("end-1c").split(".")[0]
        if int(lines) > 9999:
            messagebox.showerror("Error", "Maximum number of lines exceeded.")
            self.text_widget.delete("9999.0", tk.END)
            lines = "9999"
        self.linenumbers.insert(
            "1.0", "\n".join(str(i) for i in range(1, int(lines) + 1))
        )
        self.linenumbers.config(state="disabled")
        self.update_linenumbers_id = None

    def schedule_update_linenumbers(self, *args):
        if (
            not hasattr(self, "update_linenumbers_id")
            or self.update_linenumbers_id is None
        ):
            self.update_linenumbers_id = self.root.after_idle(self.update_linenumbers)

    def open_file(self):
        file_types = [
            ("Python Files", "*.py"),
            ("YAML Files", "*.yaml;*.yml"),
            ("JSON Files", "*.json"),
            ("Text Files", "*.txt"),
            ("All Files", "*.*"),
        ]
        file_path = filedialog.askopenfilename(filetypes=file_types)
        if file_path:
            extension = file_path.split(".")[-1]
            supported_extensions = ["py", "yaml", "yml", "json", "txt"]
            if extension not in supported_extensions:
                if messagebox.askyesno(
                    "Unsupported File Type",
                    "This will not work with syntax highlighting. Do you want to open it anyways?",
                ):
                    with open(file_path, "r") as file:
                        content = file.read()
                        self.text_widget.delete("1.0", tk.END)
                        self.text_widget.insert(tk.END, content)
            else:
                with open(file_path, "r") as file:
                    content = file.read()
                    self.text_widget.delete("1.0", tk.END)
                    self.text_widget.insert(tk.END, content)

    def save_file(self):
        file_types = [
            ("Python Files", "*.py"),
            ("YAML Files", "*.yaml"),
            ("JSON Files", "*.json"),
            ("Text Files", "*.txt"),
            ("All Files", "*.*"),
        ]
        file_path = filedialog.asksaveasfilename(filetypes=file_types)
        if file_path:
            with open(file_path, "w") as file:
                content = self.text_widget.get("1.0", tk.END)
                file.write(content)

    def show_about(self):
        messagebox.showinfo(
            "About",
            "Penguin OS PyBuilder\nA simple text editor for Python, YAML, JSON, and Text files.",
        )

    def open_source_code(self):
        webbrowser.open("https://github.com/angelotrabuco2013/PenguinOS")

    def open_terminal(self):
        os.system("start powershell.exe")

    def mainloop(self):
        self.root.mainloop()


if __name__ == "__main__":
    root = tk.Tk()
    app = PyEdit(root)
    app.mainloop()
