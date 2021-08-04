# Parses @shared toxicity data

import csv
import progressbar
import asyncio

toxicity_annotated_comments_file = '../../@shared/wiki-toxicity-data/toxicity_annotated_comments.tsv'
toxicity_annotations_file = '../../@shared/wiki-toxicity-data/toxicity_annotations.tsv'
output_file = '../toxicity_mlnet.tsv'

def parseToxicityData():
    progress = progressbar.ProgressBar()
    progress.update_progress(0) # Start a progress bar
    num_lines = sum(1 for line in open(toxicity_annotated_comments_file, mode='r', errors='ignore'))
    with open(output_file, 'a', errors='ignore') as f:
        with open(toxicity_annotated_comments_file, mode='r', encoding='utf-8', errors='ignore') as comments_fd:
            comments_rd = csv.reader(comments_fd, delimiter="\t")
            for comments_row in comments_rd:
                progress.update_progress(comments_rd.line_num / num_lines) # update progress bar
                toxicity_score = findToxicityScore(comments_row[0])
                f.write(comments_row[0] + "\t" + comments_row[1] + "\t" + toxicity_score + "\n")

def findToxicityScore(id):
    with open(toxicity_annotations_file, mode='r', encoding='utf-8', errors='ignore') as annotations_fd:
        annotations_rd = csv.reader(annotations_fd, delimiter="\t")
        for annotations_row in annotations_rd:
            if(annotations_row[0] == id):
                return annotations_row[3]
    

if __name__ == "__main__":
    asyncio.run(parseToxicityData())
