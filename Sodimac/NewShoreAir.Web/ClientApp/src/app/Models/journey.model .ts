import { Flight } from "./flight.model";

export class Journey 
{
   
    flights:Flight[] = []

    origin:string='';

    destination:string='';
    
    price:number=0;
    
    isReturn:boolean=false;
}