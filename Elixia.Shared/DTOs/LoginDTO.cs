﻿using System.Text.Json.Serialization;

namespace Elixia.Shared.DTOs;

public class LoginDTO
{
    [JsonPropertyName("userName")]
    public string UserName { get; set; }
}
