import { Injectable } from '@angular/core';


@Injectable({
  providedIn: 'root'
})
export class BlackCoverStateService {
  public isBlackCoverShowing: boolean = false;
  public picture: string | null = null;


  public setIsBlackCoverShowing = (value: boolean) => {
    this.isBlackCoverShowing = value;
  }

  public setPicture = (fileName: string) => {
    this.picture = fileName;
  }

  public setPictureNull = () => {
    this.picture = null;
  }
}