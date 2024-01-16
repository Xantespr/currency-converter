# Currency converter
Windows Form App C# currency converter downloading current data from the API of the Polish National Bank.

> [!IMPORTANT]
> This app requires a network conection, in order to fetch data from NBP public API. If it can not connect, it will display an API Error.

> NBP (Polish National Bank) API: [https://api.nbp.pl/en.html](https://api.nbp.pl/en.html).

![Converter screenshot](screenshots/preview.png?raw=true "Preview")

## Conventer contains:

- combo box with currency symbol - base currency

  ![combo box preview](screenshots/comboBox.png?raw=true "Preview")

- button to swap currencies

![Converter screenshot](screenshots/preview2.png?raw=true "Preview")

- combo box with currency symbol - target currency

- TextBox with the amount to be converted - it accepts only decimal input, max value: 1 000 000 000, updated when amountBox_TextChanged()

- question mark button - when you click it, effective date of currencies rates will display.
  
![data message](screenshots/infoBtn.png?raw=true "Preview")

- Read only textBox - displays converted amount

- "add to table" button - saves and displays the current conversion operation to the table below

> [!NOTE]
> The table is not persisted between runs!

### Created with

Visual Studio 2022 - C# Windows Form App
