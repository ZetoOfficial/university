from datetime import date, datetime

import docx
from fastapi import FastAPI, HTTPException
from pandas import DataFrame
from pydantic import BaseModel

app = FastAPI()


class Patient(BaseModel):
    fio: str
    birthdate: date
    doctor_visit_date: date
    diagnosis: str
    sex: bool


class FileInfo(BaseModel):
    path: str
    file_type: str


def convert_to_xlsx(data: Patient, path: str) -> FileInfo:
    df = DataFrame(data.dict(), index=[0])
    df.to_excel(path)
    return FileInfo(path=path, file_type='excel')


def convert_to_word(data: Patient, path: str) -> FileInfo:
    doc = docx.Document()
    doc.add_paragraph('Patient INFO')
    doc.add_paragraph(f'Ф.И.О. пациента: {data.fio}')
    doc.add_paragraph(f'Дата рождения: {data.birthdate}')
    doc.add_paragraph(f'Дата посещения врача: {data.doctor_visit_date}')
    doc.add_paragraph(f'Диагноз: {data.diagnosis}')
    doc.add_paragraph(f'Пол: {"мужчина" if data.sex else "женщина"}')
    doc.save(path)
    return FileInfo(path=path, file_type='excel')


@app.post('/convert', response_model=FileInfo)
async def convert_data_to_file(filepath: str, data: Patient):
    if filepath.endswith('.xlsx'):
        return convert_to_xlsx(data, filepath)
    if filepath.endswith('.docx'):
        return convert_to_word(data, filepath)
    raise HTTPException(status_code=400, detail='invalid file format')
