Airline Schedule User Stories 

Story 1)

Expected output:
Flight: 1, departure: YUL, arrival: YYZ, day: 1
...
Flight: 6, departure: <departure_city>, arrival: <arrival_city>, day: x


Story 2)

Expected output:
order: order-001, flightNumber: 1, departure: <departure_city>, arrival: <arrival_city>, day: x
...
order: order-099, flightNumber: 1, departure: <departure_city>, arrival: <arrival_city>, day: x
if an order has not yet been scheduled, output:
order: order-X, flightNumber: not scheduled
