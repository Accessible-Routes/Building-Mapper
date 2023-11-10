from pdf2image import convert_from_path 
import os
import glob

pdffiles = []
for file in glob.glob("*.pdf"):
    pdffiles.append(file)

if len(pdffiles) == 0:
    print("No PDF files to convert!")
    exit()

try:
    print("Creating image folder...")
    os.mkdir("PdfImages")
    print("Done!")
except:
    print("Image folder already exists!")


for pdf in pdffiles:
    images = convert_from_path(pdf)
    
    for i in range(len(images)):
        images[i].save("./PdfImages/" + pdf.split('.')[0] + str(i) +'.png', 'PNG')