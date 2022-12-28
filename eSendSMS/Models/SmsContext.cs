using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace eSendSMS.Models;

public partial class SmsContext : DbContext
{
    public SmsContext()
    {
    }

    public SmsContext(DbContextOptions<SmsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<WpCanbo> WpCanbos { get; set; }

    public virtual DbSet<WpComment> WpComments { get; set; }

    public virtual DbSet<WpCommentmeta> WpCommentmeta { get; set; }

    public virtual DbSet<WpGglcptchWhitelist> WpGglcptchWhitelists { get; set; }

    public virtual DbSet<WpLimitLogin> WpLimitLogins { get; set; }

    public virtual DbSet<WpLink> WpLinks { get; set; }

    public virtual DbSet<WpNhom> WpNhoms { get; set; }

    public virtual DbSet<WpNhomcha> WpNhomchas { get; set; }

    public virtual DbSet<WpOption> WpOptions { get; set; }

    public virtual DbSet<WpPhannhom> WpPhannhoms { get; set; }

    public virtual DbSet<WpPost> WpPosts { get; set; }

    public virtual DbSet<WpPostmetum> WpPostmeta { get; set; }

    public virtual DbSet<WpSms> WpSms { get; set; }

    public virtual DbSet<WpSmsCanbo> WpSmsCanbos { get; set; }

    public virtual DbSet<WpSmsLog> WpSmsLogs { get; set; }

    public virtual DbSet<WpSmsLogUpload> WpSmsLogUploads { get; set; }

    public virtual DbSet<WpSmsUpload> WpSmsUploads { get; set; }

    public virtual DbSet<WpTerm> WpTerms { get; set; }

    public virtual DbSet<WpTermRelationship> WpTermRelationships { get; set; }

    public virtual DbSet<WpTermTaxonomy> WpTermTaxonomies { get; set; }

    public virtual DbSet<WpTermmeta> WpTermmeta { get; set; }

    public virtual DbSet<WpUser> WpUsers { get; set; }

    public virtual DbSet<WpUsermeta> WpUsermeta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=sms;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WpCanbo>(entity =>
        {
            entity.HasKey(e => e.IdCanbo).HasName("PK_wp_canbo_id_canbo");

            entity.ToTable("wp_canbo", "sms");

            entity.Property(e => e.IdCanbo).HasColumnName("id_canbo");
            entity.Property(e => e.Gioitinh).HasColumnName("gioitinh");
            entity.Property(e => e.MaCanbo)
                .HasMaxLength(20)
                .HasColumnName("ma_canbo");
            entity.Property(e => e.Mota)
                .HasMaxLength(98)
                .HasColumnName("mota");
            entity.Property(e => e.SoDt)
                .HasMaxLength(50)
                .HasColumnName("so_dt");
            entity.Property(e => e.TenCanbo)
                .HasMaxLength(50)
                .HasColumnName("ten_canbo");
            entity.Property(e => e.TenNhom)
                .HasMaxLength(255)
                .HasColumnName("ten_nhom");
            entity.Property(e => e.Trangthai).HasColumnName("trangthai");
        });

        modelBuilder.Entity<WpComment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PK_wp_comments_comment_ID");

            entity.ToTable("wp_comments", "sms");

            entity.HasIndex(e => new { e.CommentApproved, e.CommentDateGmt }, "comment_approved_date_gmt");

            entity.HasIndex(e => e.CommentAuthorEmail, "comment_author_email");

            entity.HasIndex(e => e.CommentDateGmt, "comment_date_gmt");

            entity.HasIndex(e => e.CommentParent, "comment_parent");

            entity.HasIndex(e => e.CommentPostId, "comment_post_ID");

            entity.Property(e => e.CommentId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("comment_ID");
            entity.Property(e => e.CommentAgent)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("comment_agent");
            entity.Property(e => e.CommentApproved)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'1')")
                .HasColumnName("comment_approved");
            entity.Property(e => e.CommentAuthor)
                .HasMaxLength(255)
                .HasColumnName("comment_author");
            entity.Property(e => e.CommentAuthorEmail)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("comment_author_email");
            entity.Property(e => e.CommentAuthorIp)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("comment_author_IP");
            entity.Property(e => e.CommentAuthorUrl)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("comment_author_url");
            entity.Property(e => e.CommentContent).HasColumnName("comment_content");
            entity.Property(e => e.CommentDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("comment_date");
            entity.Property(e => e.CommentDateGmt)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("comment_date_gmt");
            entity.Property(e => e.CommentKarma).HasColumnName("comment_karma");
            entity.Property(e => e.CommentParent)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("comment_parent");
            entity.Property(e => e.CommentPostId)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("comment_post_ID");
            entity.Property(e => e.CommentType)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'comment')")
                .HasColumnName("comment_type");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<WpCommentmeta>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PK_wp_commentmeta_meta_id");

            entity.ToTable("wp_commentmeta", "sms");

            entity.HasIndex(e => e.CommentId, "comment_id");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.Property(e => e.MetaId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("meta_id");
            entity.Property(e => e.CommentId)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("comment_id");
            entity.Property(e => e.MetaKey)
                .HasMaxLength(255)
                .HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
        });

        modelBuilder.Entity<WpGglcptchWhitelist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_wp_gglcptch_whitelist_id");

            entity.ToTable("wp_gglcptch_whitelist", "sms");

            entity.HasIndex(e => e.Ip, "wp_gglcptch_whitelist$ip").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddTime)
                .HasPrecision(0)
                .HasColumnName("add_time");
            entity.Property(e => e.Ip)
                .HasMaxLength(31)
                .IsFixedLength()
                .HasColumnName("ip");
            entity.Property(e => e.IpFromInt).HasColumnName("ip_from_int");
            entity.Property(e => e.IpToInt).HasColumnName("ip_to_int");
        });

        modelBuilder.Entity<WpLimitLogin>(entity =>
        {
            entity.HasKey(e => e.LoginId).HasName("PK_wp_limit_login_login_id");

            entity.ToTable("wp_limit_login", "sms");

            entity.Property(e => e.LoginId).HasColumnName("login_id");
            entity.Property(e => e.AttemptTime)
                .HasPrecision(0)
                .HasColumnName("attempt_time");
            entity.Property(e => e.LockedTime)
                .HasMaxLength(100)
                .HasColumnName("locked_time");
            entity.Property(e => e.LoginAttempts).HasColumnName("login_attempts");
            entity.Property(e => e.LoginIp)
                .HasMaxLength(50)
                .HasColumnName("login_ip");
        });

        modelBuilder.Entity<WpLink>(entity =>
        {
            entity.HasKey(e => e.LinkId).HasName("PK_wp_links_link_id");

            entity.ToTable("wp_links", "sms");

            entity.HasIndex(e => e.LinkVisible, "link_visible");

            entity.Property(e => e.LinkId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("link_id");
            entity.Property(e => e.LinkDescription)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("link_description");
            entity.Property(e => e.LinkImage)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("link_image");
            entity.Property(e => e.LinkName)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("link_name");
            entity.Property(e => e.LinkNotes).HasColumnName("link_notes");
            entity.Property(e => e.LinkOwner)
                .HasDefaultValueSql("((1))")
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("link_owner");
            entity.Property(e => e.LinkRating).HasColumnName("link_rating");
            entity.Property(e => e.LinkRel)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("link_rel");
            entity.Property(e => e.LinkRss)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("link_rss");
            entity.Property(e => e.LinkTarget)
                .HasMaxLength(25)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("link_target");
            entity.Property(e => e.LinkUpdated)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("link_updated");
            entity.Property(e => e.LinkUrl)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("link_url");
            entity.Property(e => e.LinkVisible)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'Y')")
                .HasColumnName("link_visible");
        });

        modelBuilder.Entity<WpNhom>(entity =>
        {
            entity.HasKey(e => e.IdNhom).HasName("PK_wp_nhom_id_nhom");

            entity.ToTable("wp_nhom", "sms");

            entity.Property(e => e.IdNhom).HasColumnName("id_nhom");
            entity.Property(e => e.IdNhomcha)
                .HasDefaultValueSql("((1))")
                .HasColumnName("id_nhomcha");
            entity.Property(e => e.TenNhom)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'1')")
                .HasColumnName("ten_nhom");
            entity.Property(e => e.Trangthai)
                .HasDefaultValueSql("((1))")
                .HasColumnName("trangthai");
        });

        modelBuilder.Entity<WpNhomcha>(entity =>
        {
            entity.HasKey(e => e.IdNhomcha).HasName("PK_wp_nhomcha_id_nhomcha");

            entity.ToTable("wp_nhomcha", "sms");

            entity.Property(e => e.IdNhomcha).HasColumnName("id_nhomcha");
            entity.Property(e => e.TenNhomcha)
                .HasMaxLength(100)
                .HasColumnName("ten_nhomcha");
        });

        modelBuilder.Entity<WpOption>(entity =>
        {
            entity.HasKey(e => e.OptionId).HasName("PK_wp_options_option_id");

            entity.ToTable("wp_options", "sms");

            entity.HasIndex(e => e.Autoload, "autoload");

            entity.HasIndex(e => e.OptionName, "wp_options$option_name").IsUnique();

            entity.Property(e => e.OptionId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("option_id");
            entity.Property(e => e.Autoload)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'yes')")
                .HasColumnName("autoload");
            entity.Property(e => e.OptionName)
                .HasMaxLength(191)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("option_name");
            entity.Property(e => e.OptionValue).HasColumnName("option_value");
        });

        modelBuilder.Entity<WpPhannhom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("wp_phannhom", "sms");

            entity.Property(e => e.IdCanbo).HasColumnName("id_canbo");
            entity.Property(e => e.IdNhom).HasColumnName("id_nhom");
        });

        modelBuilder.Entity<WpPost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_wp_posts_ID");

            entity.ToTable("wp_posts", "sms");

            entity.HasIndex(e => e.PostAuthor, "post_author");

            entity.HasIndex(e => e.PostName, "post_name");

            entity.HasIndex(e => e.PostParent, "post_parent");

            entity.HasIndex(e => new { e.PostType, e.PostStatus, e.PostDate, e.Id }, "type_status_date");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.CommentCount).HasColumnName("comment_count");
            entity.Property(e => e.CommentStatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'open')")
                .HasColumnName("comment_status");
            entity.Property(e => e.Guid)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("guid");
            entity.Property(e => e.MenuOrder).HasColumnName("menu_order");
            entity.Property(e => e.PingStatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'open')")
                .HasColumnName("ping_status");
            entity.Property(e => e.Pinged).HasColumnName("pinged");
            entity.Property(e => e.PostAuthor)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("post_author");
            entity.Property(e => e.PostContent).HasColumnName("post_content");
            entity.Property(e => e.PostContentFiltered).HasColumnName("post_content_filtered");
            entity.Property(e => e.PostDate)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("post_date");
            entity.Property(e => e.PostDateGmt)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("post_date_gmt");
            entity.Property(e => e.PostExcerpt).HasColumnName("post_excerpt");
            entity.Property(e => e.PostMimeType)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("post_mime_type");
            entity.Property(e => e.PostModified)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("post_modified");
            entity.Property(e => e.PostModifiedGmt)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("post_modified_gmt");
            entity.Property(e => e.PostName)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("post_name");
            entity.Property(e => e.PostParent)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("post_parent");
            entity.Property(e => e.PostPassword)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("post_password");
            entity.Property(e => e.PostStatus)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'publish')")
                .HasColumnName("post_status");
            entity.Property(e => e.PostTitle).HasColumnName("post_title");
            entity.Property(e => e.PostType)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'post')")
                .HasColumnName("post_type");
            entity.Property(e => e.ToPing).HasColumnName("to_ping");
        });

        modelBuilder.Entity<WpPostmetum>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PK_wp_postmeta_meta_id");

            entity.ToTable("wp_postmeta", "sms");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.HasIndex(e => e.PostId, "post_id");

            entity.Property(e => e.MetaId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("meta_id");
            entity.Property(e => e.MetaKey)
                .HasMaxLength(255)
                .HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
            entity.Property(e => e.PostId)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("post_id");
        });

        modelBuilder.Entity<WpSms>(entity =>
        {
            entity.HasKey(e => e.IdSms).HasName("PK_wp_sms_id_sms");

            entity.ToTable("wp_sms", "sms");

            entity.Property(e => e.IdSms).HasColumnName("id_sms");
            entity.Property(e => e.FileDinhkem).HasColumnName("file_dinhkem");
            entity.Property(e => e.IdNguoigui)
                .HasMaxLength(10)
                .HasColumnName("id_nguoigui");
            entity.Property(e => e.NgayGui)
                .HasMaxLength(20)
                .HasColumnName("ngay_gui");
            entity.Property(e => e.Noidung).HasColumnName("noidung");
            entity.Property(e => e.SoTn).HasColumnName("so_tn");
        });

        modelBuilder.Entity<WpSmsCanbo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("wp_sms_canbo", "sms");

            entity.Property(e => e.IdCanbo).HasColumnName("id_canbo");
            entity.Property(e => e.IdNhom).HasColumnName("id_nhom");
            entity.Property(e => e.IdSms).HasColumnName("id_sms");
        });

        modelBuilder.Entity<WpSmsLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("wp_sms_log", "sms");

            entity.Property(e => e.Chitiet)
                .HasMaxLength(500)
                .HasColumnName("chitiet");
            entity.Property(e => e.IdCanbo).HasColumnName("id_canbo");
            entity.Property(e => e.IdSms).HasColumnName("id_sms");
            entity.Property(e => e.NgayGui)
                .HasMaxLength(20)
                .HasColumnName("ngay_gui");
            entity.Property(e => e.Trangthai).HasColumnName("trangthai");
        });

        modelBuilder.Entity<WpSmsLogUpload>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("wp_sms_log_upload", "sms");

            entity.Property(e => e.Chitiet)
                .HasMaxLength(500)
                .HasColumnName("chitiet");
            entity.Property(e => e.IdSms).HasColumnName("id_sms");
            entity.Property(e => e.NgayGui)
                .HasMaxLength(20)
                .HasColumnName("ngay_gui");
            entity.Property(e => e.SoDt).HasColumnName("so_dt");
            entity.Property(e => e.Trangthai).HasColumnName("trangthai");
        });

        modelBuilder.Entity<WpSmsUpload>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("wp_sms_upload", "sms");

            entity.Property(e => e.IdSms).HasColumnName("id_sms");
            entity.Property(e => e.SoDt).HasColumnName("so_dt");
        });

        modelBuilder.Entity<WpTerm>(entity =>
        {
            entity.HasKey(e => e.TermId).HasName("PK_wp_terms_term_id");

            entity.ToTable("wp_terms", "sms");

            entity.HasIndex(e => e.Name, "name");

            entity.HasIndex(e => e.Slug, "slug");

            entity.Property(e => e.TermId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("term_id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("name");
            entity.Property(e => e.Slug)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("slug");
            entity.Property(e => e.TermGroup).HasColumnName("term_group");
        });

        modelBuilder.Entity<WpTermRelationship>(entity =>
        {
            entity.HasKey(e => new { e.ObjectId, e.TermTaxonomyId }).HasName("PK_wp_term_relationships_object_id");

            entity.ToTable("wp_term_relationships", "sms");

            entity.HasIndex(e => e.TermTaxonomyId, "term_taxonomy_id");

            entity.Property(e => e.ObjectId)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("object_id");
            entity.Property(e => e.TermTaxonomyId)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("term_taxonomy_id");
            entity.Property(e => e.TermOrder).HasColumnName("term_order");
        });

        modelBuilder.Entity<WpTermTaxonomy>(entity =>
        {
            entity.HasKey(e => e.TermTaxonomyId).HasName("PK_wp_term_taxonomy_term_taxonomy_id");

            entity.ToTable("wp_term_taxonomy", "sms");

            entity.HasIndex(e => e.Taxonomy, "taxonomy");

            entity.HasIndex(e => new { e.TermId, e.Taxonomy }, "wp_term_taxonomy$term_id_taxonomy").IsUnique();

            entity.Property(e => e.TermTaxonomyId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("term_taxonomy_id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Parent)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("parent");
            entity.Property(e => e.Taxonomy)
                .HasMaxLength(32)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("taxonomy");
            entity.Property(e => e.TermId)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("term_id");
        });

        modelBuilder.Entity<WpTermmeta>(entity =>
        {
            entity.HasKey(e => e.MetaId).HasName("PK_wp_termmeta_meta_id");

            entity.ToTable("wp_termmeta", "sms");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.HasIndex(e => e.TermId, "term_id");

            entity.Property(e => e.MetaId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("meta_id");
            entity.Property(e => e.MetaKey)
                .HasMaxLength(255)
                .HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
            entity.Property(e => e.TermId)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("term_id");
        });

        modelBuilder.Entity<WpUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_wp_users_ID");

            entity.ToTable("wp_users", "sms");

            entity.HasIndex(e => e.UserEmail, "user_email");

            entity.HasIndex(e => e.UserLogin, "user_login_key");

            entity.HasIndex(e => e.UserNicename, "user_nicename");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(250)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("display_name");
            entity.Property(e => e.UserActivationKey)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("user_activation_key");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("user_email");
            entity.Property(e => e.UserLogin)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("user_login");
            entity.Property(e => e.UserNicename)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("user_nicename");
            entity.Property(e => e.UserPass)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("user_pass");
            entity.Property(e => e.UserRegistered)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("user_registered");
            entity.Property(e => e.UserStatus).HasColumnName("user_status");
            entity.Property(e => e.UserUrl)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("user_url");
        });

        modelBuilder.Entity<WpUsermeta>(entity =>
        {
            entity.HasKey(e => e.UmetaId).HasName("PK_wp_usermeta_umeta_id");

            entity.ToTable("wp_usermeta", "sms");

            entity.HasIndex(e => e.MetaKey, "meta_key");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.UmetaId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("umeta_id");
            entity.Property(e => e.MetaKey)
                .HasMaxLength(255)
                .HasColumnName("meta_key");
            entity.Property(e => e.MetaValue).HasColumnName("meta_value");
            entity.Property(e => e.UserId)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("user_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
