using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TT.Core.Domain;


namespace TT.Data.Mapping
{  
    /// <summary>
     /// Represents a category mapping configuration
     /// </summary>
    public partial class TaskMap : TTEntityTypeConfiguration<Task>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.ToTable(nameof(Task));
            builder.HasKey(task => task.Id);

            builder.Property(task => task.Title).HasMaxLength(400);

            builder.Property(task => task.Details).HasMaxLength(400);


            base.Configure(builder);
        }

        #endregion
    }
}
