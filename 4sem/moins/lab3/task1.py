from openpyxl import Workbook

N = len('Павел')
M = len('Титов')

wb = Workbook()
ws = wb.get_sheet_by_name("Sheet")

for x in range(1, N + 1):
    for y in range(1, M + 1):
        ws.cell(row=x, column=y).value = x * y

wb.save('out.xlsx')
