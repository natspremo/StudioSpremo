import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-new-flexo-job',
  templateUrl: './new-flexo-job.component.html',
  styleUrls: ['./new-flexo-job.component.css']
})
export class NewFlexoJobComponent implements OnInit {
  selectedService: string = "";
  selectedThickness: string = "";
  reactiveForm: FormGroup ;

  constructor(public formBuilder: FormBuilder) {
    this.reactiveForm = this.formBuilder.group({
      'userName': new FormControl('', [Validators.required, Validators.maxLength(100)] )
    });
   }

  ngOnInit(): void {
    
  }

  onSubmit() : void {

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

  public loadScript1() {
    let body = <HTMLDivElement> document.body;
    let script = document.createElement('script');
    script.innerHTML = '';
    script.type = "text/javascript";
    script.async = true;
    script.src = "./material-bootstrap-wizard.js";
    script.defer = true;
    body.appendChild(script);
    let script2 = document.createElement('script');
    script2.innerHTML = '';
    script2.type = "text/javascript";
    script2.async = true;
    script2.src = "./jquery-2.2.4.min.js";
    script2.defer = true;
    body.appendChild(script2);
  }
}
