using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

public class BeamHttpClient {

    //public final CookieStore cookieStore;
    //public final HttpClient http;

    protected readonly BeamAPI beam;
    //protected final HttpClientContext context;

    private String userAgent;
    private String oauthToken;

    //private JSONWebToken jwt;
    private String jwtString;
    private bool renewJwt;

    public static readonly String CSRF_TOKEN_HEADER = "x-csrf-token";
    public static readonly int CSRF_STATUS_CODE = 461;
    private String csrfToken;

    public BeamHttpClient(BeamAPI beam) : this(beam, null, null) {}
    public BeamHttpClient(BeamAPI beam, String oauthToken) : this(beam, null, null, oauthToken) {}
    public BeamHttpClient(BeamAPI beam, String httpUsername, String httpPassword) : this(beam, httpUsername, httpPassword, null) {}

    public BeamHttpClient(BeamAPI beam, String httpUsername, String httpPassword, String oauthToken) {
        this.beam = beam;
        this.cookieStore = new BasicCookieStore();

        if (httpUsername != null && httpPassword != null) {
            this.context = HttpClientContext.create();

            AuthCache ac = new BasicAuthCache();
            ac.put(new HttpHost(this.beam.basePath.getHost()), new BasicScheme());
            this.context.setAuthCache(ac);

            CredentialsProvider cp = new BasicCredentialsProvider();
            cp.setCredentials(
                    AuthScope.ANY,
                    new UsernamePasswordCredentials(httpUsername, httpPassword)
            );
            this.context.setCredentialsProvider(cp);
        } else {
            this.context = null;
        }

        this.http = this.buildHttpClient();

        if (oauthToken != null) {
            this.oauthToken = oauthToken;
        }
    }

    protected HttpClient buildHttpClient() {
        return HttpClientBuilder.create().setDefaultCookieStore(this.cookieStore).build();
    }
}

