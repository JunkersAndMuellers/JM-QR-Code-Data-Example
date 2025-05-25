# JM QR Code Data Example

## Overview

This project demonstrates how to retrieve and process packing list and item data from Junkers & Muellers GmbH using QR codes. JM provides 2D QR codes on packing lists, shipping units, delivery notes, and piece labels. These QR codes contain links to JM web servers, which return the relevant data in XML format. Due to the data size, the QR code contains only a link, not the data itself.

## QR Code Types and URLs

- **Packing list:**
  - `http://ws.jmtt.eu/GetPieceData/Getpiecedata.asmx/GetPL?uid=[uid]`
- **Shipping Unit:**
  - `http://ws.jmtt.eu/GetPieceData/Getpiecedata.asmx/GetSU?uid=[uid]&su=[su]`
- **Delivery note:**
  - `http://ws.jmtt.eu/GetPieceData/Getpiecedata.asmx/GetDN?uid=[uid]`
- **Piece label:**
  - `http://ws.jmtt.eu/GetPieceData/Getpiecedata.asmx/GetPiece?uid=[uid]`

The `[uid]` is a unique identifier to ensure data security between customers.

## Project Purpose

This C# sample application for Windows demonstrates how to: 
- Scan a QR code from a JM label or document
- Retrieve the corresponding XML data from the JM web service
- Deserialize the XML into C# data structures
- Display the data in a Windows Forms application

The project includes all necessary data structures for integration into customer-specific applications. The code can be reused in C# projects or adapted for other platforms (e.g., Xamarin for Android).

## Data Structures

### Packing List
```csharp
public class PLRecord {
    public int PackinglistNo { get; set; }
    public string CustomerName { get; set; }
    public string CustomerStreet { get; set; }
    public string CustomerCountry { get; set; }
    public string CustomerZipcode { get; set; }
    public string CustomerCity { get; set; }
    public int PieceCount { get; set; }
    public double TotalWeight { get; set; }
    public int ShippingUnitCount { get; set; }
    public List<ShippingUnitRecord> ShippingUnits { get; set; }
}
```

### Shipping Unit
```csharp
public class ShippingUnitRecord {
    public int PackinglistNo { get; set; }
    public int ShippingUnitNo { get; set; }
    public string ShippingUnitDescription { get; set; }
    public double TotalWeight { get; set; }
    public int PieceCount { get; set; }
    public List<PieceRecord> Pieces { get; set; }
}
```

### Delivery Note
```csharp
public class DNRecord {
    public int DeliveryNoteNo { get; set; }
    public string CustomerName { get; set; }
    public string CustomerStreet { get; set; }
    public string CustomerCountry { get; set; }
    public string CustomerZipcode { get; set; }
    public string CustomerCity { get; set; }
    public string DeliveryName { get; set; }
    public string DeliveryStreet { get; set; }
    public string DeliveryCountry { get; set; }
    public string DeliveryZipcode { get; set; }
    public string DeliveryCity { get; set; }
    public string ContactName { get; set; }
    public string ContactPhone { get; set; }
    public string ContactMail { get; set; }
    public int PieceCount { get; set; }
    public double TotalWeight { get; set; }
    public List<PieceRecord> Pieces { get; set; }
}
```

### Piece
```csharp
public class PieceRecord {
    public int PieceNo { get; set; }
    public int BatchNo { get; set; }
    public string ArticleNo { get; set; }
    public string ArticleDescription { get; set; }
    public int? MachineID { get; set; }
    public decimal? Brut { get; set; }
    public decimal? Allowance { get; set; }
    public decimal? Net { get; set; }
    public decimal? BrutM2 { get; set; }
    public decimal? AllowanceM2 { get; set; }
    public decimal? NetM2 { get; set; }
    public decimal? BrutCell { get; set; }
    public decimal? AllowanceCell { get; set; }
    public decimal? NetCell { get; set; }
    public decimal? CellCount { get; set; }
    public decimal? WeightBrut { get; set; }
    public decimal? Tare { get; set; }
    public decimal? WeightNet { get; set; }
    public decimal? WeightRM { get; set; }
    public decimal? WeightM2 { get; set; }
    public decimal? Witdh { get; set; }
    public string Quality { get; set; }
    public decimal? BrutFeet { get; set; }
    public decimal? AllowanceFeet { get; set; }
    public decimal? NetFeet { get; set; }
    public decimal? BrutSquareFeet { get; set; }
    public decimal? AllowanceSquareFeet { get; set; }
    public decimal? NetSquareFeet { get; set; }
    public decimal? BrutInch { get; set; }
    public decimal? AllowanceInch { get; set; }
    public decimal? NetInch { get; set; }
    public decimal? BrutSquareInch { get; set; }
    public decimal? AllowanceSquareInch { get; set; }
    public decimal? NetSquareInch { get; set; }
    public int? Parts { get; set; }
    public string UID { get; set; }
    public int? OrderNo { get; set; }
    public int? OrderPos { get; set; }
    public string PurchaseOrder { get; set; }
    public string CustomerReferenz { get; set; }
    public string CustomerArticleNo { get; set; }
    public string CustomerArticleDesc { get; set; }
    public int? DeliveryNoteNo { get; set; }
    public int? DeliveryNotePos { get; set; }
    public int? InvoiceNo { get; set; }
    public string HSCode { get; set; }
    public List<PieceErrorRecord> Errors { get; set; }
}
```

### Piece Error
```csharp
public class PieceErrorRecord {
    public string ErrorType { get; set; }
    public double Position { get; set; }
    public double Length { get; set; }
    public int ErrorCode { get; set; }
}
```

All values such as lengths or weights are metric unless otherwise specified (e.g., BrutInch, NetSquareFeet).

## Usage

1. Scan a QR code from a JM document or label.
2. The application retrieves the XML data from the JM web service.
3. The data is deserialized and displayed in the app.

## Support

For technical questions, contact: edv@jm-textile.com

---

This project is provided as a sample and starting point for your own integrations.
