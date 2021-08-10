import json

with open('sample.json', 'r') as f:
    x = json.load(f)

for p in x:
    print(p)

x['test'] = 'banana'
with open('sample.json', 'w') as outfile:
    json.dump(x, outfile)