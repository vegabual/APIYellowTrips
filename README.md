# APIYellowTrips
This is a test project creating a simple API that uses a file .PARQUET from NYC taxi records to get the information.

## Getting Started

### Dependencies

* .net SDK

### Installing

* Download the code
* Open the solution on Visual studio
* Run the proyect

### Executing program
#### On browser
* Once the project is running, a swagger window will appear
* Click on try it out on the API
* Select the values as needed
* Click on execute

#### On swagger
* Create new HTTP request
* Set the URL to http://localhost:5251/YellowTrip
* Add the selected filter on the query params
* Execute

#### Filter values and the restriction of each

##### Pagination purpose filter
* limit - Amount of records to receive - Valid values: Numeric numbers greater than 0
* offset - Amount of records to skip over - Valid values: Numeric numbers greater or equal than 0
 
##### Data filter
* Vendor - Vendor that the records come from - Valid values: 
    * CreativeMobileTechnologies
    * Verifone
* PickUpDateStart - Filters the records with pick ups before this date - Valid values: Date in format 01/DD/2024 and less than PickUpDateEnd
* PickUpDateEnd - Filters the records with pick ups after this date - Valid values: Date in format 01/DD/2024 and greater than PickUpDateStart
* DropOffStart - Filters the records with drop offs before this date - Valid values: Date in format 01/DD/2024 and less than DropOffEnd
* DropOffEnd  - Filters the records with drop offs after this date - Valid values: Date in format 01/DD/2024 and greater than DropOffDateStart
* RateCode - Filters the records according to the rate code sent - Valid values: 
    * StandardRate
    * JFK
    * Newark
    * NassauOrWestchester
    * NegotiatedFare
    * GroupRide
* PaymentType - Filters the records according to the payment type - Valid values: 
    * CreditCard
    * Cash
    * NoCharge
    * Dispute
    * Unknown
    * VoidedTrip

<!-- ROADMAP -->
## Roadmap

- [x] API working
- [ ] Server side validation
- [ ] Add endpoints for other months
- [ ] Get the PARQUET files automatically on the code

## Authors

Contributors names and contact info

Verónica Busiello
[LinkedIn]([https://twitter.com/dompizzie](https://www.linkedin.com/in/veronica-busiello/))
