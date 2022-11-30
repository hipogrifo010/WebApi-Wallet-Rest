﻿using System.ComponentModel.DataAnnotations;

namespace AlkemyWallet.Entities;

public class Login : SoftDeleteEntity

{
    [Key] public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;
}