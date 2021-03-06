
import { DeliveryOrderService } from "../../_services/deliveryOrder.service";
import { DeliveryOrderHeader } from "../../_models/DeliveryOrderHeader";

import { Order_details } from "../../_models/order_details";
import { NgbModal, NgbActiveModal } from "@ng-bootstrap/ng-bootstrap";
import { TabComponent } from "../tab/tab.component";
import { Router, ActivatedRoute } from '@angular/router';
import { OnInit, Component } from '@angular/core';

@Component({
  selector: "app-orderlist",
  templateUrl: "./orderlist.component.html",
  styleUrls: ["./orderlist.component.scss"]
})
export class OrderlistComponent implements OnInit {
  Orderlist: any;
  ModalOrderKey: string;
  orderKey: string;
  orderkey1: string;
  public order: DeliveryOrderHeader;
  modalOrderKey: string;
  public orderinfo: Order_details[];

  public pieChartLabels: string[] = [    
    "In Progress",
    "Scheduled",
    "Dispatched",
    "Hold",
    "Completed"
  ];
  public pieChartData: number[] = [30, 5, 10, 5,89];
  public pieChartType = "pie";
  public barChartOptions: any = {
    scaleShowVerticalLines: false,
    responsive: true
  };

  
  public barChartLabels: string[] = ["Dec 2018"];
  public barChartType = "bar";
  public barChartLegend = true;

  public barChartData: any[] = [
    { data: [65], label: "Total Orders" },
    { data: [28], label: "Delivery in Progress" },
    { data: [20], label: "Hold" }
  ];

  constructor(
    private modalService: NgbModal,
    private service: DeliveryOrderService,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  ngOnInit() {
    this.service
      .getOrderlist()
      .subscribe(
        data => (this.Orderlist = data),
        error => console.log(error),
        () => console.log("Get OrderList complete", this.Orderlist)
      );

   
      this.service
      .getorderstatusfordashboard()
      .subscribe(
        data => (this.pieChartData = data as any[]),
        error => console.log(error),
        () => console.log("Get pieChart Data", this.pieChartData)
      );

      console.log("Get pieChart Data", this.pieChartData)
  }
  open(orderParams) {
   // this.order = orderParams;
    this.ModalOrderKey = orderParams;
       const modalRef = this.modalService.open(TabComponent,{ size:'lg',backdrop:true, windowClass : 'myCustomModalClass'});
      modalRef.componentInstance.orderKeyinput =   this.ModalOrderKey;  
  }

  viewOrder(orderKey: string) {
    this.router.navigate(["/doIntake", orderKey]);
    //this.router.navigate(['/tab',orderKey]);
  }
  navigatetoTab(order: string) {
    this.router.navigate(["/tab", order]);
  }

  viewOrderinfo(orderParams) {
   // this.order = orderParams;

  // this.order.OrderKey =orderParams;
  this.ModalOrderKey = orderParams;

  }
  // events
  public chartClicked(e:any):void {
    console.log(e);
  }
 
  public chartHovered(e:any):void {
    console.log(e);
  }
}
