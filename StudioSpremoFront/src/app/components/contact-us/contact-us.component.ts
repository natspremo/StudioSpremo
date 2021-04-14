import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-contact-us',
  templateUrl: './contact-us.component.html',
  styleUrls: ['./contact-us.component.css']
})
export class ContactUsComponent implements OnInit {
  name: string = "";
  email: string = "";
  testMessage: string = "";
  phone: string = "";
  reactiveForm: FormGroup = new FormGroup({
    'name': new FormControl('', [Validators.required]),
    'email': new FormControl('', [Validators.required, Validators.email]),
    'phone': new FormControl(''),
    'testMessage': new FormControl('', [Validators.required, Validators.maxLength(100)])
  });
  constructor() { }

  ngOnInit(): void {
  }

  onSubmit() {
    
  }
}
