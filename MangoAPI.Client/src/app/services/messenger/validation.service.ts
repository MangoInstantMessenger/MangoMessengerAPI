import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ValidationService {

  private allowedFileExtensions = ["jpg", "JPG", "txt", "TXT", "pdf", "PDF", "png", "PNG"];


  validateField(field: string, fieldName: string): boolean {
    if(field == '' || field == undefined) {
      alert(`Error: field '${fieldName}' is empty.`);
      return false;
    }
    return true;
  }

  validateFileName(fileName: string): void {
    let fileExtension = fileName.split('.')[1];

    if(!this.allowedFileExtensions.includes(fileExtension)) {
      alert('Error: file extension not allowed.');
      throw new Error('Error: file extension not allowed.');
    }
    if(fileName.length > 50) {
      alert('Error: file name length exceeds the allowed symbol count.');
      throw new Error('Error: file name length exceeds the allowed symbol count.');
    }
  }
}
