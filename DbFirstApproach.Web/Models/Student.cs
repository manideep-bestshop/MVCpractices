﻿using System;
using System.Collections.Generic;

namespace DbFirstApproach.Web.Models;

public partial class Student
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public bool Subscribed { get; set; }
}
