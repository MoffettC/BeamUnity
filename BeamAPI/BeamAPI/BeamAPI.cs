﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class BeamAPI {
    //string json = new JsonConvert.SerializeObject();

    public readonly Uri basePath;

    //public Gson gson;
    //public final BeamHttpClient http;
    //public final ListeningExecutorService executor;
    //protected final ServiceManager<AbstractBeamService> services;

    private static readonly Uri DEFAULT_BASE_PATH = new Uri("https://beam.pro/api/v1/");

    public BeamAPI() : this(null) { }

    public BeamAPI(String oauthToken) : this(DEFAULT_BASE_PATH, oauthToken) { }

    public BeamAPI(Uri basePath, String oauthToken) : this(basePath, null, null, oauthToken) { }

    public BeamAPI(Uri basePath, String httpUsername, String httpPassword) : this(basePath, httpUsername, httpPassword, null) { }

    public BeamAPI(Uri basePath, String httpUsername, String httpPassword, String oauthToken) {
        if (basePath != null) {
            this.basePath = basePath;
        } else {
            this.basePath = DEFAULT_BASE_PATH;
        }

        //this.gson = new GsonBuilder()
        //        .registerTypeAdapter(InetSocketAddress.class, new IPEndPoint())  //public IPEndPoint test = new IPEndPoint(); JSON type to convert
        //        .registerTypeAdapter(URI.class, new URIAdapter())     //UriAdapter(by beam) JSON type to convert
        //        .registerTypeAdapter(Date.class, DateAdapter.v1())    //DateTime JSON type to convert
        //.create();

        //    this.executor = MoreExecutors.listeningDecorator(Executors.newFixedThreadPool(10));
        //ThreadPool pool = new ThreadPool();
        // ThreadPool.QueueUserWorkItem(f.ThreadPoolCallback, i);

        //    this.http = new BeamHttpClient(this, httpUsername, httpPassword, oauthToken);
        //    this.services = new ServiceManager<>();

        //    this.register(new UsersService(this));
        //    this.register(new ChatService(this));
        //    this.register(new EmotesService(this));
        //    this.register(new ChannelsService(this));
        //    this.register(new TypesService(this));
        //    this.register(new TetrisService(this));
        //    this.register(new JWTService(this));
    }


    //public <T extends AbstractBeamService> T use(Class<T> service) {
    //    return this.services.get(service);
    //}

    //public boolean register(AbstractBeamService service) {
    //    return this.services.register(service);
    //}
    //public void setUserAgent(String agent) {
    //    this.http.setUserAgent(agent);
    //}

}
