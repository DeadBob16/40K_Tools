import random
import csv


random1 = random.randint(0, 100)

if random1 < 75:
	random2 = random.randint(0, 100) + 75
	line_number = random2
	with open(PerilsTable.csv, 'rb') as f:
    	mycsv = csv.reader(f)
    	mycsv = list(mycsv)
    	text = mycsv[line_number]
		return "Perhaps the Warp is too dangerous" + text


line_number = random1
with open(PerilsTable.csv, 'rb') as f:
    mycsv = csv.reader(f)
    mycsv = list(mycsv)
    text = mycsv[line_number]
	return text
