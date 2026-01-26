
<style>
	:root {
		--bg: #0f172a;
		--card: #111827;
		--accent: #38bdf8;
		--accent-2: #a855f7;
		--text: #e5e7eb;
		--muted: #94a3b8;
		--border: #1f2937;
	}

	body {
		margin: 0;
		font-family: "Segoe UI", "Helvetica Neue", Arial, sans-serif;
		background: radial-gradient(circle at 15% 20%, rgba(168, 85, 247, 0.15), transparent 25%),
								radial-gradient(circle at 80% 0%, rgba(56, 189, 248, 0.15), transparent 22%),
								var(--bg);
		color: var(--text);
	}

	.page {
		max-width: 960px;
		margin: 0 auto;
		padding: 32px 24px 64px;
	}

	.card {
		background: linear-gradient(145deg, rgba(17, 24, 39, 0.9), rgba(17, 24, 39, 0.7));
		border: 1px solid var(--border);
		border-radius: 18px;
		padding: 24px 28px;
		box-shadow: 0 25px 60px rgba(0, 0, 0, 0.35);
	}

	.hero {
		display: grid;
		gap: 12px;
		margin-bottom: 20px;
	}

	.badge {
		display: inline-flex;
		align-items: center;
		gap: 8px;
		padding: 6px 12px;
		border-radius: 999px;
		background: rgba(56, 189, 248, 0.12);
		color: #bae6fd;
		letter-spacing: 0.02em;
		font-weight: 600;
		text-transform: uppercase;
		font-size: 12px;
		width: fit-content;
	}

	h1 {
		margin: 0;
		font-size: 32px;
		letter-spacing: -0.02em;
		color: #f8fafc;
	}

	h2 {
		margin: 0 0 10px;
		font-size: 20px;
		color: #e2e8f0;
	}

	.lead {
		margin: 0;
		font-size: 15px;
		line-height: 1.6;
		color: var(--muted);
	}

	.highlight {
		display: inline-block;
		padding: 2px 10px;
		border-radius: 10px;
		background: rgba(168, 85, 247, 0.14);
		color: #e9d5ff;
		font-weight: 600;
	}

	.grid {
		display: grid;
		gap: 16px;
	}
	@media (min-width: 720px) {
		.grid-two {
			grid-template-columns: 1.1fr 1fr;
			gap: 18px;
		}
	}

	.pill {
		display: inline-flex;
		align-items: center;
		gap: 6px;
		padding: 6px 10px;
		border-radius: 999px;
		border: 1px solid var(--border);
		background: rgba(255, 255, 255, 0.03);
		color: var(--muted);
		font-size: 12px;
	}

	.muted {
		color: var(--muted);
	}
</style>

<div class="page">
	<header class="hero">
		<span class="badge">Architecture Pattern</span>
		<h1>CQRS: Command Query Responsibility Segregation</h1>
		<p class="lead">Separate <span class="highlight">Commands</span> that change state from <span class="highlight">Queries</span> that read state, so each side can evolve independently.</p>
	</header>

	<section class="card grid grid-two">
		<div>
			<h2>What is CQRS?</h2>
			<p class="muted">CQRS is a software design pattern that separates read operations (Queries) from write operations (Commands) into different models and responsibilities. This separation ensures that data modification logic and data retrieval logic are handled independently, making the application cleaner, more scalable, and easier to maintain.</p>
		</div>
		<div class="grid" aria-label="quick-points">
			<span class="pill">Commands: change data</span>
			<span class="pill">Queries: read data</span>
			<span class="pill">Independent scaling</span>
			<span class="pill">Clearer responsibilities</span>
		</div>
	</section>

	<section class="card grid grid-two">
		<div>
			<h2>In simple words</h2>
			<ul class="muted" style="margin: 0; padding-left: 18px; line-height: 1.6;">
				<li>Command -> Changes data (create, update, delete)</li>
				<li>Query -> Reads data (get, list, search)</li>
				<li>A command does not return data; it performs an action</li>
				<li>A query does not change data; it only returns data</li>
			</ul>
		</div>
		<div>
			<h2>Why CQRS is used</h2>
			<ul class="muted" style="margin: 0; padding-left: 18px; line-height: 1.6;">
				<li>Clear separation of responsibilities</li>
				<li>Better performance tuning for read and write paths</li>
				<li>Easier testing and maintenance</li>
				<li>Pairs well with Clean Architecture plus MediatR (commands and queries modeled as requests/handlers)</li>
			</ul>
		</div>
	</section>
</div>
