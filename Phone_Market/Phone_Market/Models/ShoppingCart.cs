﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Phone_Market.Models;

public partial class ShoppingCart
{
    public Guid UserId { get; set; }

    public Guid ProductId { get; set; }

    public int Quantity { get; set; }

    public virtual Product Product { get; set; }

    public virtual User User { get; set; }
}