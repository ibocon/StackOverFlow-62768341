﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace WebApplication;

internal sealed class InMemoryGuidValueGenerator
	: ValueGenerator<Guid>
{
	public override bool GeneratesTemporaryValues => false;

	public override Guid Next(EntityEntry entry)
	{
		return Guid.NewGuid();
	}
}
