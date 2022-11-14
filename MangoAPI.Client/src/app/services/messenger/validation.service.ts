import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ValidationService {

  private allowedFileExtensions = ["jpg", "JPG", "txt", "TXT", "pdf", "PDF", "png", "PNG"];
  private allowedPictureFileExtensions = ["jpg", "JPG", "png", "PNG"];


  validateField(field: string, fieldName: string): boolean {
    if(field == '' || field == undefined) {
      alert(`Error: field '${fieldName}' is empty.`);
      return false;
    }
    return true;
  }

  validateFileName(fileName: string): boolean {
    const fileExtension = fileName.split('.')[1];

    if(!this.allowedFileExtensions.includes(fileExtension)) {
      alert('Error: file extension not allowed.');
      return false;
    }
    if(fileName.length > 50) {
      alert('Error: file name length exceeds the allowed symbol count.');
      return false;
    }

    return true;
  }

  validatePictureFileName(fileName: string): boolean {
    const fileExtension = fileName.split('.')[1];

    if(!this.allowedPictureFileExtensions.includes(fileExtension)) {
      alert('Error: file extension not allowed.');
      return false;
    }

    if(fileName.length > 50) {
      alert('Error: file name length exceeds the allowed symbol count.');
      return false;
    }

    return true;
  }
}
