﻿//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//=================================

using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tarteeb.Api.Models.Foundations.Times;

namespace Tarteeb.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Time> Times { get; set; }

        public async ValueTask<Time> InsertTimeAsync(Time time) =>
            await InsertTimeAsync(time);

        public IQueryable<Time> SelectAllTimes(Time time) =>
            SelectAll<Time>();

        public async ValueTask<Time> DeleteTimeAsync(Time time) =>
            await DeleteAsync(time);
    }
}