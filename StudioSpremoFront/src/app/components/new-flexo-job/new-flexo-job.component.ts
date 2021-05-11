import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-new-flexo-job',
  templateUrl: './new-flexo-job.component.html',
  styleUrls: ['./new-flexo-job.component.css']
})
export class NewFlexoJobComponent implements OnInit {
  step1: boolean = true;
  step2: boolean = false;
  step3: boolean = false;
  step4: boolean = false;
  radioSelected: string = "";
  prepress: boolean = false;
  production: boolean = false;
  nextStep: boolean = true;
  alert: boolean = false;
  selectedThickness: string = "";
  thicknesses: Array<string> = ['1.18', '2.34', '5.32'];
  selectedPrintingType: string = "";
  printingTypes: Array<string> = ['Unutrašnja', 'Spoljašnja'];
  constructor(public formBuilder: FormBuilder) {
  }

  ngOnInit(): void {

  }

  onSubmit(): void {

  }

  radioChange(event: any) {
    this.radioSelected = event.target.value;
    this.nextStep = false;
  }

  setSteps(step1: boolean, step2: boolean, step3: boolean, step4: boolean) {
    this.step1 = step1;
    this.step2 = step2;
    this.step3 = step3;
    this.step4 = step4;
  }

  nextStep1(): void {      //kliknuto prvo NEXT
    if (this.radioSelected != "") {
      if (this.radioSelected == "prepress") {
        this.prepress = true;
        this.production = false;
      }
      else if (this.radioSelected == "production") {
        this.production = true;
        this.prepress = false;
      }
      this.setSteps(false, true, false, false);
      this.alert = false;
    } else {
      this.alert = true;
    }
  }

  nextStep2(): void {
    this.setSteps(false, false, true, false);
  }

  nextStep3(): void {
    this.setSteps(false, false, false, true);
  }

  getThickness(t: string): void {
    this.selectedThickness = t;
  }

  getPrintingType(p: string): void {
    this.selectedPrintingType = p;
  }
}
