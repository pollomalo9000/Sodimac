import { Component } from '@angular/core';
import { FormBuilder, FormGroup, ValidatorFn, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { CoreApiService } from '../services/core-api.service';
import { Journey } from '../Models/journey.model ';
import { ReactiveFormsModule } from '@angular/forms';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {


  sku: string;

  constructor(private _fb: FormBuilder, private _coreApi: CoreApiService) {

    this.sku = '';

   
  }


  onKeyup(event: any) {
    event.target.value = event.target.value.toUpperCase();
  }

  private _initGroup(): FormGroup {
    return this._fb.group({
      origin: ['',Validators.required,],
      destination: ['',Validators.required,],
      roundtrip: ['',Validators.required,],

     }, );
  }


  comparoCampos() {
  const origin = this.form.controls['origin'].value;
  const destination = this.form.controls['destination'].value;
  const roundtrip = this.form.controls['roundtrip'].value;
  debugger;
  this.same = origin === destination ; 

}

  

  public onSubmit(): void {



    this.Consultar();
    
  }



  Consultar() {
  

    var origin= this.form.controls['origin'].value;
    var destination = this.form.controls['destination'].value;
    var roundtrip = this.form.controls['roundtrip'].value;

    this._coreApi
      .findAllById<Journey>('flights', `${origin}/${destination}/${roundtrip}`)
      .subscribe(
        (journeys) => {

         debugger;
          var a = journeys;
          this.journeys = journeys;

        },
        (err) => {
   
          this.message = err.error.error;

          //this._openModalError();
        }
      );
  
}



}
