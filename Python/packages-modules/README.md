# Packages and Modules in Python

This project aims to demonstrate modules in Python.

## Prerequisites

- [Python][technology-main]

## Hidden Path

Python files defined in a subdirectory are not searched by default. The contents of [`hidden`](./hidden) are not found unless Python is explicitly informed to look for it.

#### Not Found

- From a terminal in this directory, open the python REPL via running `python`
- Enter `import path_test`
- Note that `path_test.py` was not found and the console output indicates that via the following error
```python
Traceback (most recent call last):
File "<stdin>", line 1, in <module>
ModuleNotFoundError: No module named 'path_test'.
```

#### Found

- From a terminal in this directory, open the python REPL via running `python`
- Enter `import sys`
- Enter `sys.path.append('hidden')
- Enter `import path_test`
- Note that `path_test.py` was found and the console output `Python found me` per the contents of that file.

## Package

Python files defined in a subdirectory which contain a `__init__.py` are searched by default. The contents of [`package`](./package) are found and identified as a module.

#### Importing Package

- From a terminal in this directory, open the python REPL via running `python`
- Enter `import package`
- Note that this succeeded with no further requirements.
- Enter `type(package)`
- Note that this indicates package is a `module`
- Enter `package.__file__`
- Note that the file [`__init__.py`](package/__init__.py) is the file being executed.

#### Additional Reading
- [PEP 420][pep-420]

[technology-main]: https://www.python.org/downloads/
[pep-420]: https://www.python.org/dev/peps/pep-0420/