import { Injectable } from '@angular/core';


@Injectable({
  providedIn: 'root'
})
export class ModalWindowStateService {
  public isModalWindowShowing: boolean = false;
  public picture: string | null = null;


  public setIsModalWindowShowing = (value: boolean) => {
    this.isModalWindowShowing = value;
  }

  public setPicture = (fileName: string) => {
    this.picture = fileName;
  }

  public setPictureNull = () => {
    this.picture = null;
  }
}