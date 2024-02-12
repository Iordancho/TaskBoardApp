using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskBoardApp3.Data.Models;

namespace TaskBoardApp3.Data.Configuration;

public class BoardConfiguration: IEntityTypeConfiguration<Board>
{
    public void Configure(EntityTypeBuilder<Board> builder)
    {
        builder.HasData(new Board[]
        {
            ConfigurationHelper.InProgressBoard,
            ConfigurationHelper.DoneBoard,
            ConfigurationHelper.OpenBoard,
            ConfigurationHelper.ForReviewBoard
        });
    }
}