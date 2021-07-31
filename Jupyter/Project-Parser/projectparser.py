# Script intended to iterate over the sandbox looking for projects which aren't in a solution.
import os
import os.path
import sys
import progressbar

def main(argv):
    # Start searching
    print ('Searching for projects that cannot be found in solutions:')
    progress = progressbar.ProgressBar()
    progress.update_progress(0) # Start a progress bar

    projectCount = 0 
    projectFiles = []
    solutionFiles = []
    solutionlessProjectFiles = []
    sandboxPath = os.path.expandvars(argv[0])
    exclude = set(['node_modules', 'packages', 'bin', 'obj'])
    for dirpath, dirnames, filenames in os.walk(sandboxPath, topdown=True):
        [dirnames.remove(d) for d in list(dirnames) if d in exclude]
        for projectName in [f for f in filenames if f.endswith("proj")]:
            if projectName:
                projectFiles.append(projectName)
        for solutionName in [f for f in filenames if f.endswith(".sln")]:
            if solutionName:
                solutionFiles.append(os.path.join(dirpath, solutionName))

    for projectName in projectFiles:
        projectCount = projectCount + 1
        progress.update_progress(projectCount / len(projectFiles)) # update progress bar
        found = False
        foundInFile = ''
        for solution in solutionFiles:
            if projectName in open(solution).read(): # Does the solution contain the project name?
                found = True
                foundInFile = solutionName
                break
        if(found == False):
            solutionlessProjectFiles.append(projectName) # We couldn't find a solution. Append name to the solutionless project list 

    print('Solutions in directory: %s', len(solutionFiles))
    print('Projects in directory: %s', len(projectFiles))
    print('Solutionless Projects in directory: %s', len(solutionlessProjectFiles))
    for solutionlessProject in solutionlessProjectFiles:
        print(solutionlessProject)

if __name__ == "__main__":
    main(sys.argv[1:])