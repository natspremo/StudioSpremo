import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-new-flexo-job',
  templateUrl: './new-flexo-job.component.html',
  styleUrls: ['./new-flexo-job.component.css']
})
export class NewFlexoJobComponent implements OnInit {
  selectedService: string = "";
  selectedThickness: string = "";
  

  constructor() { }

  ngOnInit(): void {
  }


  setServiceKlise() {
    this.selectedService = "Klišea";
  }

  setServicePriprema() {
    this.selectedService = "Pripreme za štampu";
  }

  setThickness(thick: string) {
    this.selectedThickness = thick;
  }
}
