import { Time } from "@angular/common";
import { Tms_routes } from "./tms_routes";
import { Comments } from './comments';
import { DeliveryOrderHeader } from './DeliveryOrderHeader';

export class Order_details {
        OrderDetailKey :string;
        containerid:string;
        OrderKey:string;
        ContainerSize:string;
        ContainerNo:string;
        Chassis:string;
        SealNo: string;
        Weight:number;
        AppDateFrom:Date;
        AppDateTo:Date;
        PickupDateTime:Date;       
        DropOffDateTime:Date;      
        ActualPickupDateTime:string;
        ActualDropOffDateTime:string;  
        LastFreeDay:Date; 
        SchedulerNotes:string;    
        status:string;
        statusdate:string;
        holdreason:string;
        holddate:string;
        ContainerSizeDesc:string;
        StatusDesc:string;
        HoldReasonDesc:string;  
        orderroutes:Tms_routes;
        Comments:string;     
        nextaction:string; 

        CreatedBy:string;
        createdDate:string;
        DOHeader: DeliveryOrderHeader;
}
