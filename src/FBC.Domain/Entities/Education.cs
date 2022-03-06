﻿namespace FBC.Domain.Entities;

public class Education : Entity
{
    public string? Name { get; set; }
    public string? Link { get; set; }
    public bool IsHigherEducation { get; set; }

    public virtual List<UserEducation> Students { get; set; } = new();
}
