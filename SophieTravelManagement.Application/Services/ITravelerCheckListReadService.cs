﻿namespace SophieTravelManagement.Application.Services;

public interface ITravelerCheckListReadService
{
    Task<bool> ExistByNameAsync(string name);
}
