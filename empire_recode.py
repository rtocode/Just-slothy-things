#! /usr/bin/python
#written by pic
import argparse,os

parser = argparse.ArgumentParser(description="Recode a PS Empire encoded string to evade AV detection")
parser.add_argument("-f", "--infile", dest="infilename")
parser.add_argument("-o", "--outfile", dest="outfilename")
args = parser.parse_args()
infile = args.infilename
outfile = args.outfilename

if infile:
	if os.path.isfile(infile):
		with open(infile) as fstring:
			txt_object = fstring.read()
			encoded_string = list(txt_object.split(" -Enc ")[1].swapcase())
			encoded_string = ''.join([char.replace(char, char+"3000") for char in encoded_string])
			print encoded_string

			fstring.close()
	else:
		print "File %s doesn't exist" % infile

if infile and outfile:
	with open(outfile, "w") as ofile:
		ofile.write(encoded_string)
		ofile.close()
